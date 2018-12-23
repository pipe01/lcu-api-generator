using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using IOPath = System.IO.Path;

namespace LCU_API_Generator
{
    class Program
    {
        private static string[] Args;

        static async Task Main(string[] args)
        {
            Args = args;
            string configPath = args.FirstOrDefault(o => !o.StartsWith('-')) ?? "config.json";

            var config = Config.Load(configPath);
            config.Save(configPath);

            if (args.Contains("-client"))
                config.GetSwaggerFromClient = true;

            string swagger;

            if (config.GetSwaggerFromClient)
            {
                try
                {
                    swagger = await GetSwaggerFromClient();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed to get swagger file:");
                    Console.WriteLine(ex);
                    ReadIfNotCli();
                    return;
                }

                if (swagger == null)
                    return;
            }
            else
            {
                if (File.Exists(config.SwaggerFile))
                {
                    Console.WriteLine("Reading file at " + config.SwaggerFile);

                    swagger = await File.ReadAllTextAsync(config.SwaggerFile);
                }
                else
                {
                    Console.WriteLine("Swagger file at '{0}' not found", IOPath.GetFullPath(config.SwaggerFile));
                    ReadIfNotCli();
                    return;
                }
            }
            
            var json = JObject.Parse(swagger);

            var jdefinitions = (JObject)json["definitions"];
            Console.WriteLine("Found {0} definitions", jdefinitions.Count);

            var jpaths = (JObject)json["paths"];
            Console.WriteLine("Found {0} paths", jpaths.Count);

            var serializer = new JsonSerializer
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore
            };

            var definitions = jdefinitions.Children().Select(o =>
            {
                var prop = o as JProperty;
                var def = prop.Value.ToObject<Definition>(serializer);

                def.Name = prop.Name;

                return def;
            }).ToArray();

            var paths = jpaths.Children().SelectMany(o =>
            {
                var pathProp = (JProperty)o;

                return pathProp.Value.Select(j =>
                {
                    var prop = (JProperty)j;
                    var p = prop.Value.ToObject<Path>(serializer);

                    p.PathName = pathProp.Name;
                    p.Method = prop.Name;

                    return p;
                }).ToArray();
            })
            .GroupBy(o =>
            {
                string[] parts = o.PathName.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

                if ((parts.Length > 1 || o.Tags.Contains("Plugins")) && o.PathName != "/{plugin}/assets/{path}")
                {
                    return parts[0].Prettify(true);
                }

                return "BuiltIn";
            })
            .Where(o => (config.IncludeEndpoints == null || config.IncludeEndpoints.Contains(o.Key))
                     && (config.ExcludeEndpoints == null || !config.ExcludeEndpoints.Contains(o.Key)))
            .ToArray();

            Console.WriteLine("Resolving references...");

            int refs = 0;
            foreach (var item in definitions)
            {
                ResolveReferences(item, definitions, ref refs);
            }
            
            foreach (var item in paths.SelectMany(o => o))
            {
                item.Parameters = item.Parameters.DistinctBy(o => o.Name).ToArray();

                foreach (var param in item.Parameters)
                {
                    ResolveReferences(param, definitions, ref refs);
                }

                foreach (var resp in item.Responses)
                {
                    if (resp.Value.Schema != null)
                        resp.Value.Schema = ResolveReferences(resp.Value.Schema, definitions, ref refs);
                }
            }

            Console.WriteLine("Resolved {0} model references", refs);
            
            Console.Write("Writing path controllers: ");
            WritePaths(paths, config);

            Console.Write("Writing definition models: ");
            WriteModels(definitions, config);

            Console.WriteLine();
            Console.WriteLine("Done!");
            ReadIfNotCli();
        }

        private static void ReadIfNotCli()
        {
            if (!Args.Contains("-cli"))
                Console.ReadKey(true);
        }

        private static Task<string> GetSwaggerFromClient()
        {
            Console.WriteLine("Trying to connect to client");

            if (!LCU.Connect())
            {
                Console.WriteLine("Make sure the client is running!");
                ReadIfNotCli();
                return null;
            }

            return LCU.GetSwagger();
        }

        private static void WritePaths(IEnumerable<IGrouping<string, Path>> groups, Config config)
        {
            if (!Directory.Exists(config.InterfaceOutFolder))
                Directory.CreateDirectory(config.InterfaceOutFolder);

            int i = 0, total = groups.Count(), lastLength = 0;
            var pos = (Console.CursorLeft, Console.CursorTop);
            foreach (var item in groups)
            {
                int spaces = lastLength - item.Key.Length;
                if (spaces < 0)
                    spaces = 0;
                lastLength = item.Key.Length;

                Console.SetCursorPosition(pos.CursorLeft, pos.CursorTop);
                Console.WriteLine("{0}/{1} {2}{3}", i++, total, item.Key, new string(' ', spaces));
                
                File.WriteAllText(IOPath.Combine(config.InterfaceOutFolder, item.Key + ".cs"), ClassGenerator.Generate(item, config));
            }

            Console.SetCursorPosition(pos.CursorLeft, pos.CursorTop);
            Console.WriteLine("done                    ");
        }

        private static void WriteModels(IEnumerable<Definition> definitions, Config config)
        {
            if (!Directory.Exists(config.ModelOutFolder))
                Directory.CreateDirectory(config.ModelOutFolder);

            int i = 0, count = definitions.Count(), lastLength = 0;
            var pos = (Console.CursorLeft, Console.CursorTop);
            foreach (var item in definitions)
            {
                int spaces = lastLength - item.Name.Length;
                if (spaces < 0)
                    spaces = 0;
                lastLength = item.Name.Length;

                Console.SetCursorPosition(pos.CursorLeft, pos.CursorTop);
                Console.WriteLine("{0}/{1} {2}{3}", i++, count, item.Name, new string(' ', spaces));

                File.WriteAllText(IOPath.Combine(config.ModelOutFolder, item.Name + ".cs"), ClassGenerator.Generate(item, config));
            }

            Console.SetCursorPosition(pos.CursorLeft, pos.CursorTop);
            Console.WriteLine("done                         ");
        }
        
        
        private static Path.Parameter ResolveReferences(Path.Parameter parameter, IEnumerable<Definition> definitions, ref int counter)
        {
            if (parameter.Schema != null)
            {

                if (parameter.Schema.Reference != null)
                {
                    counter++;
                    parameter.Schema = definitions.Single(o => o.Name == parameter.Schema.Reference.Split('/').Last());
                }

                ResolveReferences(parameter.Schema, definitions, ref counter);
            }

            ResolveReferences((Definition)parameter, definitions, ref counter);

            return parameter;
        }

        private static Definition ResolveReferences(Definition definition, IEnumerable<Definition> definitions, ref int counter)
        {
            if (definition.Reference != null)
            {
                definition = ResolveReferences(GetDefinition(definition.Reference), definitions, ref counter);
            }

            if (definition.Items?.Reference != null)
            {
                counter++;
                definition.Items = GetDefinition(definition.Items.Reference);
            }

            if (definition.Properties != null)
            {
                foreach (var property in definition.Properties.ToArray())
                {
                    if (property.Value.Reference != null)
                    {
                        definition.Properties[property.Key] = GetDefinition(property.Value.Reference);

                        counter++;
                    }

                    ResolveReferences(definition.Properties[property.Key], definitions, ref counter);
                }
            }
            
            return definition;
            
            Definition GetDefinition(string fullName)
            {
                return definitions.Single(o => o.Name == fullName.Split('/').Last());
            }
        }
    }
}

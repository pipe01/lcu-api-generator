using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCU_API_Generator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string configPath = args.Length == 1 ? args[0] : "config.json";

            var config = Config.Load(configPath);

            Console.WriteLine("Reading file at " + config.SwaggerFile);

            JObject json;

            using (var fileReader = File.OpenText(config.SwaggerFile))
            {
                json = await JObject.LoadAsync(new JsonTextReader(fileReader));
            }

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
            }).ToArray();

            int refs = 0;
            foreach (var item in definitions)
            {
                ResolveReferences(item, definitions, ref refs);
            }

            foreach (var item in paths)
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

            Console.Write("Writing definitions models: ");
            WriteModels(definitions, config);

            Console.WriteLine("Done!");
            Console.ReadKey(true);
        }

        private static void WritePaths(Path[] paths, Config config)
        {
            var groups = paths.GroupBy(o =>
            {
                string[] parts = o.PathName.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

                if ((parts.Length > 1 || o.Tags.Contains("Plugins")) && o.PathName != "/{plugin}/assets/{path}")
                {
                    return parts[0].Prettify(true);
                }

                return "BuiltIn";
            });
            
            var path = "../../../out/Interfaces";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            int i = 0, total = groups.Count();
            var pos = (Console.CursorLeft, Console.CursorTop);
            foreach (var item in groups)
            {
                Console.SetCursorPosition(pos.CursorLeft, pos.CursorTop);
                Console.WriteLine("{0}/{1}", i++, total);
                
                File.WriteAllText($"{path}/{item.Key}.cs", ClassGenerator.Generate(item, config));
            }

            Console.SetCursorPosition(pos.CursorLeft, pos.CursorTop);
            Console.WriteLine("done         ");
        }

        private static void WriteModels(Definition[] definitions, Config config)
        {
            var path = "../../../out/Models";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            int i = 0;
            var pos = (Console.CursorLeft, Console.CursorTop);
            foreach (var item in definitions)
            {
                Console.SetCursorPosition(pos.CursorLeft, pos.CursorTop);
                Console.WriteLine("{0}/{1}", i++, definitions.Length);

                File.WriteAllText($"{path}/{item.Name}.cs", ClassGenerator.Generate(item, config));
            }

            Console.SetCursorPosition(pos.CursorLeft, pos.CursorTop);
            Console.WriteLine("done         ");
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

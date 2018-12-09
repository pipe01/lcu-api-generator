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
        private static string[] Keywords = new []
        {
            "bool", "byte", "sbyte", "short", "ushort", "int", "uint", "long", "ulong", "double", "float", "decimal",
            "string", "char", "void", "object", "typeof", "sizeof", "null", "true", "false", "if", "else", "while", "for", "foreach", "do", "switch",
            "case", "default", "lock", "try", "throw", "catch", "finally", "goto", "break", "continue", "return", "public", "private", "internal",
            "protected", "static", "readonly", "sealed", "const", "fixed", "stackalloc", "volatile", "new", "override", "abstract", "virtual",
            "event", "extern", "ref", "out", "in", "is", "as", "params", "__arglist", "__makeref", "__reftype", "__refvalue", "this", "base",
            "namespace", "using", "class", "struct", "interface", "enum", "delegate", "checked", "unchecked", "unsafe", "operator", "implicit", "explicit"
        };

        static async Task Main(string[] args)
        {
            string path = args.Length == 1 ? args[0] : "swagger.json";
            Console.WriteLine("Reading file at " + path);

            JObject json;

            using (var fileReader = File.OpenText(path))
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
            WritePaths(paths);

            Console.Write("Writing definitions models: ");
            Console.ReadKey(true);
            WriteModels(definitions);

            Console.WriteLine("Done!");
            Console.ReadKey(true);
        }

        private static void WritePaths(Path[] paths)
        {
            var groups = paths.GroupBy(o =>
            {
                string[] parts = o.PathName.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

                if ((parts.Length > 1 || o.Tags.Contains("Plugins")) && o.PathName != "/{plugin}/assets/{path}")
                {
                    return Prettify(parts[0]);
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
                
                File.WriteAllText($"{path}/{item.Key}.cs", GenerateClass(item, "LCU_API_Generator"));
            }

            Console.SetCursorPosition(pos.CursorLeft, pos.CursorTop);
            Console.WriteLine("done         ");
        }

        private static void WriteModels(Definition[] definitions)
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

                File.WriteAllText($"{path}/{item.Name}.cs", GenerateClass(item, "LCU_API_Generator"));
            }

            Console.SetCursorPosition(pos.CursorLeft, pos.CursorTop);
            Console.WriteLine("done         ");
        }
        
        private static string GenerateClass(IGrouping<string, Path> pathGroup, string @namespace, string classModifier = "public",
            bool properties = true)
        {
            var builder = new StringBuilder();

            string name = pathGroup.Key == "System" ? "SSystem" : pathGroup.Key;

            builder.Append(@$"using System.Threading.Tasks;
using static {@namespace}.GenerationUtils;

namespace {@namespace}
{{
    {classModifier} static class {name}
    {{
");

            foreach (var path in pathGroup)
            {
                var response = path.Responses.First().Value;
                var returnType = response.Schema == null ? null : $"<{GetCSType(response.Schema)}>";

                if (path.Summary != null)
                {
                    builder.AppendLine("/// <summary>", 2)
                           .AppendLine("/// " + path.Summary, 2)
                           .AppendLine("/// </summary>", 2);
                }

                foreach (var param in path.Parameters)
                {
                    if (param.Description != null)
                        builder.AppendLine($"/// <param name=\"{Prettify(param.Name, false)}\">{param.Description}</param>", 2);
                }

                builder.Append(@$"public static Task{returnType} {path.OperationID}(", 2)
                       .AppendJoin(", ", path.Parameters.Select(o => $"[Parameter(\"{o.Name}\", \"{o.In}\")] {GetCSType(o.Schema ?? o, true, true)} {Prettify(o.Name, false)}"))
                       .AppendLine(")")
                       .Append("=> ", 3);

                string body = "";
                string pathStr = path.PathName;

                foreach (var item in path.Parameters.Where(o => o.In == "path"))
                {
                    pathStr = pathStr.Replace(item.Name, Prettify(item.Name, false));
                }

                if (path.Parameters.Any(o => o.In == "query"))
                {
                    pathStr += "?" + string.Join("&", path.Parameters
                        .Where(o => o.In == "query")
                        .Select(o => $"{o.Name}={{System.Net.WebUtility.UrlEncode({Prettify(o.Name, false)}.ToString())}}"));
                }

                if (path.Parameters.Any(o => o.In == "body"))
                {
                    body = ", " + Prettify(path.Parameters.Single(o => o.In == "body").Name, false);
                }
                
                builder.AppendLine($"Sender.Request{returnType}(\"{path.Method}\", $\"{pathStr}\"{body});");
            }

            builder.AppendLine("}", 1).AppendLine("}");

            return builder.ToString();
        }

        private static string GenerateClass(Definition definition, string @namespace, string classModifier = "public",
            bool properties = true)
        {
            var builder = new StringBuilder();

            string objectType = definition.Enum != null ? "enum" : "class";

            builder.Append(@$"using Newtonsoft.Json;

namespace {@namespace}
{{{(objectType == "class" ? "\n    [JsonObject]" : "")}
    {classModifier} {objectType} {definition.Name}
    {{
");
            
            if (objectType == "class")
            {
                foreach (var item in definition.Properties)
                {
                    if (item.Value.Description != null)
                    {
                        builder.AppendLine("/// <summary>", 2)
                               .AppendLine("/// " + item.Value.Description, 2)
                               .AppendLine("/// </summary>", 2);
                    }

                    string name = item.Key.Replace('-', '_');
                    name = char.ToUpper(name[0]) + name.Substring(1);

                    if (name == definition.Name)
                        name += "2";

                    builder.AppendLine($"[JsonProperty(\"{item.Key}\")]", 2)
                           .AppendLine($"public {GetCSType(item.Value)} {name}{(properties ? " { get; set; }" : ";")}", 2);
                }
            }
            else
            {
                foreach (var item in definition.Enum)
                {
                    string name = char.ToUpper(item[0]) + item.Substring(1);
                    name = name.Replace('-', '_');

                    builder.AppendLine($"{name},", 2);
                }
            }
            
            builder.AppendLine("}", 1).AppendLine("}");

            return builder.ToString();
        }

        private static string Prettify(string str, bool firstUpper = true)
        {
            var name = "";

            bool upper = firstUpper;
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (upper)
                {
                    upper = false;
                    c = char.ToUpper(c);
                }

                if (c == '-')
                {
                    upper = true;
                    continue;
                }

                name += c;
            }

            if (Keywords.Contains(name))
                name = "@" + name;

            return name;
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

        private static string GetCSType(Definition definition, bool forPath = false, bool isParameter = false)
        {
            switch (definition.Type)
            {
                case "array":
                    return (definition.Items.Name ?? GetCSType(new Definition
                    {
                        Type = definition.Items.Type,
                        Format = definition.Items.Format
                    })) + "[]";
                case "integer" when definition.Format == "int64":
                    return "long";
                case "integer":
                    return "int";
                case "number":
                    return "float";
                case "boolean":
                    return "bool";
                case "object" when isParameter && definition.Name != null:
                    return definition.Name;
            }
            
            return forPath ? definition.Type : (definition.Name ?? definition.Type);
        }
    }
}

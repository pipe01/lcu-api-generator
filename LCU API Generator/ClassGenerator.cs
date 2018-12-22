using System.Linq;
using System.Text;

namespace LCU_API_Generator
{
    public static class ClassGenerator
    {
        public static string Generate(IGrouping<string, Path> pathGroup, Config config)
        {
            var builder = new StringBuilder();

            string name = pathGroup.Key == "System" ? "SSystem" : pathGroup.Key;

            if (config.ModelNamespace != config.InterfaceNamespace)
            {
                builder.AppendLine($"using {config.ModelNamespace};");
            }

            builder.Append($@"using System.Threading.Tasks;
using static {config.GenerationUtilsFullName};

namespace {config.InterfaceNamespace}
{{
    {config.ClassVisibility} static class {name}
    {{
");

            foreach (var path in pathGroup)
            {
                var response = path.Responses.First().Value;
                var returnType = response.Schema == null ? null : $"<{response.Schema.GetCSType()}>";

                path.Parameters = path.Parameters.OrderByDescending(o => o.Required).ToArray();

                if (config.GenerateXmlDocs)
                {
                    builder.AppendLine("/// <summary>", 2);

                    if (path.Summary != null)
                        builder.AppendLine("/// " + path.Summary, 2);

                    builder.AppendLine($"/// <para>{path.Method.ToUpper()} {path.PathName}</para>", 2);
                    builder.AppendLine("/// </summary>", 2);

                    foreach (var param in path.Parameters)
                    {
                        if (param.Description != null)
                            builder.AppendLine($"/// <param name=\"{param.Name.Prettify()}\">{param.Description}</param>", 2);
                    }
                }

                builder.Append($@"public static Task{returnType} {path.OperationID}(", 2)
                       .AppendJoin(", ", path.Parameters.Select(o => $"[Parameter(\"{o.Name}\", \"{o.In}\")] {(o.Schema ?? o).GetCSType(true, true)} {o.Name.Prettify()}{(!o.Required ? " = default": "")}"))
                       .AppendLine(")")
                       .Append("=> ", 3);

                string body = "";
                string pathStr = path.PathName;

                foreach (var item in path.Parameters.Where(o => o.In == "path"))
                {
                    pathStr = pathStr.Replace(item.Name, item.Name.Prettify());
                }

                if (path.Parameters.Any(o => o.In == "query"))
                {
                    pathStr += "?" + string.Join("&", path.Parameters
                        .Where(o => o.In == "query")
                        .Select(o =>
                        {
                            var str = $"{o.Name}={{System.Net.WebUtility.UrlEncode({o.Name.Prettify()}.ToString())}}";
                            return o.Required ? str : $"{{({o.Name.Prettify()} != default ? $\"{str}\" : null)}}";
                        }));
                }

                if (path.Parameters.Any(o => o.In == "body"))
                {
                    body = ", " + path.Parameters.Single(o => o.In == "body").Name.Prettify();
                }

                builder.AppendLine($"Sender.Request{returnType}(\"{path.Method}\", $\"{pathStr}\"{body});");
            }

            builder.AppendLine("}", 1)
                   .AppendLine("}");

            return builder.ToString();
        }

        public static string Generate(Definition definition, Config config)
        {
            var builder = new StringBuilder();

            string objectType = definition.Enum != null ? "enum" : "class";

            builder.Append($@"using Newtonsoft.Json;

namespace {config.ModelNamespace}
{{{(objectType == "class" ? "\n    [JsonObject]" : "")}
    {config.ClassVisibility} {objectType} {definition.Name}
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
                           .AppendLine($"public {item.Value.GetCSType()} {name}{(config.UseProperties ? " { get; set; }" : ";")}", 2);
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

            builder.AppendLine("}", 1)
                   .AppendLine("}");

            return builder.ToString();
        }

    }
}

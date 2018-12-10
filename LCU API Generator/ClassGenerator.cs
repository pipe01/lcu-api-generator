using System.Linq;
using System.Text;

namespace LCU_API_Generator
{
    public static class ClassGenerator
    {
        public static string Generate(IGrouping<string, Path> pathGroup, string @namespace, string classModifier = "public",
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
                var returnType = response.Schema == null ? null : $"<{response.Schema.GetCSType()}>";

                if (path.Summary != null)
                {
                    builder.AppendLine("/// <summary>", 2)
                           .AppendLine("/// " + path.Summary, 2)
                           .AppendLine("/// </summary>", 2);
                }

                foreach (var param in path.Parameters)
                {
                    if (param.Description != null)
                        builder.AppendLine($"/// <param name=\"{param.Name.Prettify()}\">{param.Description}</param>", 2);
                }

                builder.Append(@$"public static Task{returnType} {path.OperationID}(", 2)
                       .AppendJoin(", ", path.Parameters.Select(o => $"[Parameter(\"{o.Name}\", \"{o.In}\")] {(o.Schema ?? o).GetCSType(true, true)} {o.Name.Prettify()}"))
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
                        .Select(o => $"{o.Name}={{System.Net.WebUtility.UrlEncode({o.Name.Prettify()}.ToString())}}"));
                }

                if (path.Parameters.Any(o => o.In == "body"))
                {
                    body = ", " + path.Parameters.Single(o => o.In == "body").Name.Prettify();
                }

                builder.AppendLine($"Sender.Request{returnType}(\"{path.Method}\", $\"{pathStr}\"{body});");
            }

            builder.AppendLine("}", 1).AppendLine("}");

            return builder.ToString();
        }

        public static string Generate(Definition definition, string @namespace, string classModifier = "public",
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
                           .AppendLine($"public {item.Value.GetCSType()} {name}{(properties ? " { get; set; }" : ";")}", 2);
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

    }
}

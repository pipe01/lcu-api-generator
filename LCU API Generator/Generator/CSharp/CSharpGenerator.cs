using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using LCU_API_Generator.CodeDom;
using Newtonsoft.Json;
using Resourcer;

namespace LCU_API_Generator.Generator.CSharp
{
    public class CSharpGenerator : IGenerator
    {
        public string LanguageKey => "cs";

        public void Setup(Workspace workspace)
        {
            workspace.WriteToFile("Include.cs", Resource.AsString("Include.cs"));
        }

        public void GenerateSchema(Class schema, Workspace workspace)
        {
            var builder = new StringBuilder();

            builder.AppendLine("using Newtonsoft.Json;")
                   .AppendLine();

            if (workspace.Options.SchemaNamespace != null)
                builder.AI().AppendLine($"namespace {workspace.Options.SchemaNamespace}")
                       .AI().AppendLine("{")
                       .Indent();

            if (schema is SchemaClass cls)
            {
                builder.AI().AppendLine($"public class {cls.Name}")
                       .AI().AppendLine("{")
                       .Indent();


                foreach (var field in cls.Fields)
                {
                    string name = field.Name.Dehumanize();

                    if (name == cls.Name)
                        name = name[0] + name;

                    builder.AI().AppendLine($"[JsonProperty(\"{field.Name}\")]")
                           .AI().AppendLine($"public {GetCSType(field.Type)} {name};");
                }


                builder.Unindent()
                       .AI().AppendLine("}");
            }
            else if (schema is EnumClass @enum)
            {
                builder.AI().AppendLine("[JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]")
                       .AI().AppendLine($"public enum {@enum.Name}")
                       .AI().AppendLine("{")
                       .Indent();

                foreach (var field in @enum.ItemNames)
                {
                    builder.AI().AppendLine($"[System.Runtime.Serialization.EnumMember(Value = \"{field}\")]")
                           .AI().AppendLine($"{field.Dehumanize()},");
                }


                builder.Unindent()
                       .AI().AppendLine("}");
            }


            if (workspace.Options.SchemaNamespace != null)
                builder.Unindent()
                       .AI().AppendLine("}");

            workspace.WriteToFile("Schemas/" + schema.Name + ".cs", builder.ToString());
        }

        private string GetCSType(VariableType type)
        {
            if (type == null)
                return "void";

            if (type is PrimitiveVariableType primitive)
            {
                switch (primitive.Type)
                {
                    case PrimitiveTypes.Int32:
                        return "int";
                    case PrimitiveTypes.Int64:
                        return "long";
                    case PrimitiveTypes.Boolean:
                        return "bool";
                    case PrimitiveTypes.String:
                        return "string";
                    case PrimitiveTypes.Float:
                        return "float";
                    case PrimitiveTypes.Double:
                        return "double";
                    case PrimitiveTypes.UnknownObject:
                        return "object";
                }
            }
            else if (type is ClassVariableType cls)
            {
                return cls.Class.Name;
            }
            else if (type is ArrayVariableType arr)
            {
                return GetCSType(arr.ItemsType) + "[]";
            }

            throw new ArgumentException("Invalid type");
        }

        public void GenerateInterface(PathsClass paths, Workspace workspace)
        {
            var builder = new StringBuilder();

            builder.AppendLine("using Newtonsoft.Json;")
                   .AppendLine("using static GenerationUtils;")
                   .AppendLine();

            if (workspace.Options.SchemaNamespace != null)
                builder.AI().AppendLine($"namespace {workspace.Options.SchemaNamespace}")
                       .AI().AppendLine("{")
                       .Indent();

            builder.AI().AppendLine($"public class {paths.Name}")
                   .AI().AppendLine("{");

            builder.Indent();

            foreach (var method in paths.Methods)
            {
                var paramNames = method.Parameters.Keys.ToDictionary(o => o, o => o.Prettify());

                if (method.Documentation != null)
                {
                    builder.AI().AppendLine("///<summary>")
                           .AI().AppendLine($"///{method.Documentation.Summary}")
                           .AI().AppendLine("///</summary>");
                }

                foreach (var param in method.Parameters)
                {
                    if (param.Value.Documentation != null)
                        builder.AI().AppendLine($"///<param name=\"{paramNames[param.Key]}\">{param.Value.Documentation.Summary}</param>");
                }

                builder.AI().Append($"public {GetCSType(method.ResponseType)} {method.Name}(");

                if (method.RequestType != null)
                {
                    builder.Append($"{GetCSType(method.RequestType)} body");

                    if (method.Parameters.Count > 0)
                        builder.Append(", ");
                }

                foreach (var param in method.Parameters)
                {
                    builder.Append($"{GetCSType(param.Value.Type)} {paramNames[param.Key]}");

                    if (param.Key != method.Parameters.Keys.Last())
                        builder.Append(", ");
                }

                builder.AppendLine(")")
                       .Indent();

                builder.AI().Append("=> Sender.Request");

                if (method.ResponseType != null)
                    builder.Append($"<{GetCSType(method.ResponseType)}>");

                builder.Append($"(\"{method.HttpMethod.ToString().ToLower()}\", $\"{method.Path}");

                bool isFirstQueryParam = true;
                foreach (var param in method.Parameters.Where(o => o.Value.Position == ParameterPosition.Query))
                {
                    if (isFirstQueryParam)
                        builder.Append("?");
                    else
                        builder.Append("&");

                    builder.Append($"{param.Key}={param.Key}");

                    isFirstQueryParam = false;
                }

                //TODO Header parameters

                builder.AppendLine("\");");

                builder.Unindent();
            }

            builder.Unindent();

            builder.AI().AppendLine("}");

            if (workspace.Options.SchemaNamespace != null)
                builder.Unindent()
                       .AI().AppendLine("}");

            workspace.WriteToFile("Interfaces/" + paths.Name + ".cs", builder.ToString());
        }

        public void Finish(Workspace workspace)
        {
        }
    }
}

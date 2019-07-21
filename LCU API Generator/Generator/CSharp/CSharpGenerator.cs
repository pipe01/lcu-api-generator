using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using LCU_API_Generator.CodeDom;
using Newtonsoft.Json;

namespace LCU_API_Generator.Generator.CSharp
{
    public class CSharpGenerator : IGenerator
    {
        public string Key => "cs";

        public void GenerateSchema(Class schema, Workspace workspace)
        {
            var builder = new StringBuilder();

            builder.AppendLine("using Newtonsoft.Json;")
                   .AppendLine();

            if (workspace.Options.SchemaNamespace != null)
                builder.AppendIndentation().AppendLine($"namespace {workspace.Options.SchemaNamespace}")
                       .AppendIndentation().AppendLine("{")
                       .Indent();

            if (schema is SchemaClass cls)
            {
                builder.AppendIndentation().AppendLine($"public class {cls.Name}")
                       .AppendIndentation().AppendLine("{")
                       .Indent();


                foreach (var field in cls.Fields)
                {
                    string name = field.Name.Dehumanize();

                    if (name == cls.Name)
                        name = name[0] + name;

                    builder.AppendIndentation().AppendLine($"[JsonProperty(\"{field.Name}\")]")
                           .AppendIndentation().AppendLine($"public {GetCSType(field.Type)} {name};");
                }


                builder.Unindent()
                       .AppendIndentation().AppendLine("}");
            }
            else if (schema is EnumClass @enum)
            {
                builder.AppendIndentation().AppendLine("[JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]")
                       .AppendIndentation().AppendLine($"public enum {@enum.Name}")
                       .AppendIndentation().AppendLine("{")
                       .Indent();

                foreach (var field in @enum.ItemNames)
                {
                    builder.AppendIndentation().AppendLine($"[System.Runtime.Serialization.EnumMember(Value = \"{field}\")]")
                           .AppendIndentation().AppendLine($"{field.Dehumanize()},");
                }


                builder.Unindent()
                       .AppendIndentation().AppendLine("}");
            }


            if (workspace.Options.SchemaNamespace != null)
                builder.Unindent()
                       .AppendIndentation().AppendLine("}");

            Console.WriteLine(schema.Name);
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
    }
}

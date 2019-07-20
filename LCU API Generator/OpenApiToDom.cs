using LCU_API_Generator.CodeDom;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCU_API_Generator
{
    public class OpenApiToDom
    {
        private readonly JObject Json;
        private readonly IDictionary<string, Class> SchemaClasses = new Dictionary<string, Class>();
        private readonly Stack<string> SchemaStack = new Stack<string>();

        public OpenApiToDom(JObject json)
        {
            this.Json = json;
        }

        public IDictionary<string, Class> ParseSchemas()
        {
            var dic = new Dictionary<string, Class>();

            foreach (var prop in Json["components"]["schemas"].Children<JProperty>())
            {
                dic[prop.Name] = GetSchemaClass(prop.Name);
            }

            return dic;
        }

        private Class GetSchemaClass(string name)
        {
            if (SchemaStack.Contains(name))
            {
                //Console.WriteLine("Circular reference detected on " + name);
                return null;
            }

            SchemaStack.Push(name);

            try
            {
                //Console.WriteLine("Getting schema class with name " + name);

                if (!SchemaClasses.TryGetValue(name, out var cls))
                    SchemaClasses[name] = cls = ParseClass(name);

                return cls;
            }
            finally
            {
                SchemaStack.Pop();
            }
        }

        private Class ParseClass(string name)
        {
            var cls = Json["components"]["schemas"][name];

            if (cls == null)
                throw new ArgumentException($"Class with name {name} not found");

            if (cls["type"]?.Value<string>() == "object")
            {
                var fields = new List<Field>();

                foreach (var prop in cls["properties"].Children<JProperty>())
                {
                    var fieldType = GetType(prop.Value);
                    fields.Add(new Field(prop.Name, null, fieldType));
                }

                return new SchemaClass(name, null, fields.ToArray());
            }
            else if (cls["enum"] != null)
            {
                var items = cls["enum"].Select(o => o.Value<string>());

                //Currently all enum are of type "string"
                return new EnumClass(name, null, new PrimitiveVariableType(PrimitiveTypes.String), items.ToArray());
            }

            throw new InvalidOperationException("Invalid schema type found: " + cls["type"]);
        }

        private VariableType GetType(JToken type)
        {
            if (type["$ref"] != null)
                return new ClassVariableType(GetSchemaClass(type["$ref"].Value<string>().Split('/').Last()));

            var typeStr = type["type"]?.Value<string>();
            var format = type["format"]?.Value<string>();

            switch (typeStr)
            {
                case "integer" when format == "int32" || format == null:
                    return new PrimitiveVariableType(PrimitiveTypes.Int32);
                case "integer" when format == "int64":
                    return new PrimitiveVariableType(PrimitiveTypes.Int64);
                case "number" when format == "float":
                    return new PrimitiveVariableType(PrimitiveTypes.Float);
                case "number" when format == "double":
                    return new PrimitiveVariableType(PrimitiveTypes.Double);
                case "string":
                    return new PrimitiveVariableType(PrimitiveTypes.String);
                case "boolean":
                    return new PrimitiveVariableType(PrimitiveTypes.Boolean);
                case "array":
                    return new ArrayVariableType(GetType(type["items"]));
                case "object" when type["additionalProperties"] != null:
                    return new PrimitiveVariableType(PrimitiveTypes.UnknownObject);
            }

            throw new Exception($"Invalid type found: {typeStr}" + (format != null ? $" with format {format}" : null));
        }
    }
}

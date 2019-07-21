using Humanizer;
using LCU_API_Generator.CodeDom;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

        #region Schemas
        public IDictionary<string, Class> ParseAllSchemas()
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
                return new SelfClass(name, null);
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

            var desc = cls["description"]?.Value<string>();
            var doc = desc != null ? new Documentation(desc) : null;

            if (cls["type"]?.Value<string>() == "object")
            {
                var fields = new List<Field>();

                foreach (var prop in cls["properties"].Children<JProperty>())
                {
                    var fieldType = GetSchemaType(prop.Value);
                    fields.Add(new Field(
                        prop.Name,
                        prop.Value["description"] != null ? new Documentation(prop.Value["description"].Value<string>()) : null,
                        fieldType));
                }

                return new SchemaClass(name, doc, fields.ToArray());
            }
            else if (cls["enum"] != null)
            {
                var items = cls["enum"].Select(o => o.Value<string>());

                //Currently all enum are of type "string"
                return new EnumClass(name, doc, new PrimitiveVariableType(PrimitiveTypes.String), items.ToArray());
            }

            throw new InvalidOperationException("Invalid schema type found: " + cls["type"]);
        }

        private VariableType GetSchemaType(JToken type, string fullKey = null)
        {
            if (type["$ref"] != null)
                return new ClassVariableType(GetSchemaClass(type["$ref"].Value<string>().Split('/').Last()));

            if (type["enum"] != null && fullKey != null)
                return new ClassVariableType(new EnumClass(fullKey, null, GetSchemaType(type), type["enum"].Select(o => o.Value<string>()).ToArray()));

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
                    return new ArrayVariableType(GetSchemaType(type["items"]));
                case "object" when type["additionalProperties"] != null:
                    return new PrimitiveVariableType(PrimitiveTypes.UnknownObject);
            }

            throw new Exception($"Invalid type found: {typeStr}" + (format != null ? $" with format {format}" : null));
        }
        #endregion

        #region Paths
        public IEnumerable<Class> ParseAllTags()
        {
            var parsedTags = new List<string>();

            foreach (JProperty path in Json["paths"])
            {
                foreach (JProperty method in path.Value)
                {
                    foreach (string tag in (method.Value["tags"] as JArray).Values<string>())
                    {
                        if (!parsedTags.Contains(tag))
                        {
                            parsedTags.Add(tag);
                            yield return ParsePathsUnderTag(tag);
                        }
                    }
                }
            }
        }

        public Class ParsePathsUnderTag(string tag)
        {
            var methods = new List<Method>();

            foreach (JProperty path in Json["paths"])
            {
                foreach (JProperty method in path.Value)
                {
                    if ((method.Value["tags"] as JArray).Values<string>().Contains(tag))
                    {
                        methods.Add(ParsePathMethod(method.Value, new HttpMethod(method.Name), path.Name));
                    }
                }
            }

            string name = tag.Dehumanize();

            if (name.StartsWith("Plugin") && name != "Plugins")
                name = name.Substring("Plugin".Length);

            return new PathsClass(name, null, methods.ToArray());
        }

        private Method ParsePathMethod(JToken json, HttpMethod httpMethod, string path)
        {
            var parameters = new Dictionary<string, Parameter>();
            var methodName = json["operationId"].Value<string>();
            var methodDoc = json["summary"] != null ? new Documentation(json["summary"].Value<string>()) : null;
            VariableType responseType = null;

            foreach (var param in json["parameters"])
            {
                var name = param["name"].Value<string>();

                if (parameters.ContainsKey(name))
                    continue; //Some parameters are duplicate for absolutely no reason

                var type = GetSchemaType(param, methodName + name.Dehumanize());
                var position = Enum.Parse<ParameterPosition>(param["in"].Value<string>(), true);
                var doc = json["description"] != null ? new Documentation(json["description"].Value<string>()) : null;

                parameters.Add(name, new Parameter(name, doc, type, position, param["required"].Value<bool>()));
            }

            var resp = json["responses"]?["200"]?["content"]?["application/json"]?["schema"];

            if (resp != null)
                responseType = GetSchemaType(resp, methodName + "Response");

            return new Method(methodName, methodDoc, path, parameters, httpMethod, responseType);
        }
        #endregion

        public IEnumerable<Class> GetReferencedSchemas(string tag)
        {
            var paths = ParsePathsUnderTag(tag);

            return (paths as ITypeContainer).GetTypes().OfType<ClassVariableType>().Select(o => o.Class);
        }
    }
}

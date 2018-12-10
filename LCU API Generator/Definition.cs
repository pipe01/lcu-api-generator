using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace LCU_API_Generator
{
    [DebuggerDisplay("{Name != null ? Name : Type != null ? Type : Reference != null ? Reference : \"something\"}")]
    public class Definition
    {
        public string Name;
        public string Type;
        public string Format;
        public string Description;

        public Dictionary<string, Definition> Properties;
        public Definition Items;
        public string[] Enum;

        [JsonProperty("$ref")]
        public string Reference;

        public string GetCSType(bool forPath = false, bool isParameter = false)
        {
            switch (this.Type)
            {
                case "array":
                    return (this.Items.Name ?? new Definition
                    {
                        Type = this.Items.Type,
                        Format = this.Items.Format
                    }.GetCSType()) + "[]";
                case "integer" when this.Format == "int64":
                    return "long";
                case "integer":
                    return "int";
                case "number":
                    return "float";
                case "boolean":
                    return "bool";
                case "object" when isParameter && this.Name != null:
                    return this.Name;
            }

            return forPath ? this.Type : (this.Name ?? this.Type);
        }
    }
}

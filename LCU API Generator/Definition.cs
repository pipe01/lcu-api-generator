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
    }
}

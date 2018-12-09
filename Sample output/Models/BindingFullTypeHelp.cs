using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class BindingFullTypeHelp
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("fields")]
        public BindingFullFieldHelp[] Fields { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("nameSpace")]
        public string NameSpace { get; set; }
        [JsonProperty("size")]
        public int Size { get; set; }
        [JsonProperty("tags")]
        public string[] Tags { get; set; }
        [JsonProperty("values")]
        public BindingFullEnumValueHelp[] Values { get; set; }
    }
}

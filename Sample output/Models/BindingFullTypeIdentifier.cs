using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class BindingFullTypeIdentifier
    {
        [JsonProperty("elementType")]
        public string ElementType { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

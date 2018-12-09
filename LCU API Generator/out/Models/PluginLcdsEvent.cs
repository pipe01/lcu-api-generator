using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PluginLcdsEvent
    {
        [JsonProperty("body")]
        public object Body { get; set; }
        [JsonProperty("clientId")]
        public string ClientId { get; set; }
        [JsonProperty("subtopic")]
        public string Subtopic { get; set; }
        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }
}
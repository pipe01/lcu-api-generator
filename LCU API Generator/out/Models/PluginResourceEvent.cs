using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PluginResourceEvent
    {
        [JsonProperty("data")]
        public object Data { get; set; }
        [JsonProperty("eventType")]
        public PluginResourceEventType EventType { get; set; }
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}
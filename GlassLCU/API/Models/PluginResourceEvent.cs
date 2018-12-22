using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

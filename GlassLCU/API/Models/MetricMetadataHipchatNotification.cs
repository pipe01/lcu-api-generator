using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class MetricMetadataHipchatNotification
    {
        [JsonProperty("roomid")]
        public string Roomid { get; set; }
        [JsonProperty("tags")]
        public string Tags { get; set; }
    }
}

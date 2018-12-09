using Newtonsoft.Json;

namespace LCU_API_Generator
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

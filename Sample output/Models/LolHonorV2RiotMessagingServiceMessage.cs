//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolHonorV2RiotMessagingServiceMessage
    {
        [JsonProperty("payload")]
        public string Payload { get; set; }
        [JsonProperty("resource")]
        public string Resource { get; set; }
        [JsonProperty("service")]
        public string Service { get; set; }
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEndOfGameRMSMessage
    {
        [JsonProperty("payload")]
        public string Payload { get; set; }
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}

//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolSummonerRMSMessage
    {
        [JsonProperty("payload")]
        public string Payload { get; set; }
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}

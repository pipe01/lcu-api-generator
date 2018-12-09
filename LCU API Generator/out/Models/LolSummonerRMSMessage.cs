using Newtonsoft.Json;

namespace LCU_API_Generator
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

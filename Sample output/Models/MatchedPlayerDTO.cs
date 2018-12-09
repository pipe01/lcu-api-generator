using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class MatchedPlayerDTO
    {
        [JsonProperty("captain")]
        public PlayerInfoDTO Captain { get; set; }
        [JsonProperty("players")]
        public PlayerInfoDTO[] Players { get; set; }
        [JsonProperty("rosterId")]
        public string RosterId { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LeaguesLcdsAggregatedStatsKey
    {
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("userId")]
        public long UserId { get; set; }
    }
}

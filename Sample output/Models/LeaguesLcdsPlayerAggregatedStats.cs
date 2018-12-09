using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LeaguesLcdsPlayerAggregatedStats
    {
        [JsonProperty("aggregatedStats")]
        public LeaguesLcdsAggregatedStats AggregatedStats { get; set; }
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LeaguesLcdsAggregatedStats
    {
        [JsonProperty("key")]
        public LeaguesLcdsAggregatedStatsKey Key { get; set; }
        [JsonProperty("lifetimeStatistics")]
        public LeaguesLcdsAggregatedStat[] LifetimeStatistics { get; set; }
    }
}

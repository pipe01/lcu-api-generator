using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

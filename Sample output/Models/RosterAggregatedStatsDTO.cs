using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RosterAggregatedStatsDTO
    {
        [JsonProperty("periodStats")]
        public RosterPeriodAggregatedStatsDTO[] PeriodStats { get; set; }
        [JsonProperty("playerStats")]
        public object PlayerStats { get; set; }
    }
}

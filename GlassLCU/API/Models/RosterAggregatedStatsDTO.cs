using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

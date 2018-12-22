using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

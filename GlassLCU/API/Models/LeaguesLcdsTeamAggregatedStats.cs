using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LeaguesLcdsTeamAggregatedStats
    {
        [JsonProperty("id")]
        public LeaguesLcdsTeamIdDTO Id { get; set; }
        [JsonProperty("playerAggregatedStatsList")]
        public LeaguesLcdsPlayerAggregatedStats[] PlayerAggregatedStatsList { get; set; }
        [JsonProperty("queueType")]
        public string QueueType { get; set; }
    }
}

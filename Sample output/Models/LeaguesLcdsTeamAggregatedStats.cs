using Newtonsoft.Json;

namespace LCU_API_Generator
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

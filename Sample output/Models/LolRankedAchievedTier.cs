using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRankedAchievedTier
    {
        [JsonProperty("division")]
        public long Division { get; set; }
        [JsonProperty("queueType")]
        public LolRankedLeagueQueueType QueueType { get; set; }
        [JsonProperty("tier")]
        public LolRankedLeagueTier Tier { get; set; }
    }
}

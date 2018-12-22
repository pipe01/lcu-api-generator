using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCareerStatsStatsQueryRequest
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("position")]
        public LolCareerStatsSummonersRiftPosition Position { get; set; }
        [JsonProperty("queueType")]
        public LolCareerStatsCareerStatsQueueType QueueType { get; set; }
        [JsonProperty("rankTier")]
        public LolCareerStatsRankedTier RankTier { get; set; }
        [JsonProperty("season")]
        public int Season { get; set; }
    }
}

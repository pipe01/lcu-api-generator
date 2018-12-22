using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCareerStatsPositionStatsQueryRequest
    {
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

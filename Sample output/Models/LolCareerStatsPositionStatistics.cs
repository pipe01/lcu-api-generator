using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCareerStatsPositionStatistics
    {
        [JsonProperty("experts")]
        public LolCareerStatsExpertPlayer[] Experts { get; set; }
        [JsonProperty("position")]
        public LolCareerStatsSummonersRiftPosition Position { get; set; }
        [JsonProperty("queueStats")]
        public LolCareerStatsStatisticsByQueue[] QueueStats { get; set; }
    }
}

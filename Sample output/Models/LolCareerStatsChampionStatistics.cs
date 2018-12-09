using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCareerStatsChampionStatistics
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("experts")]
        public LolCareerStatsExpertPlayer[] Experts { get; set; }
        [JsonProperty("queueStats")]
        public LolCareerStatsStatisticsByQueue[] QueueStats { get; set; }
    }
}

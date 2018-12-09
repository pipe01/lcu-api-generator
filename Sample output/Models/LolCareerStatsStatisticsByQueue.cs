using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCareerStatsStatisticsByQueue
    {
        [JsonProperty("queueType")]
        public LolCareerStatsCareerStatsQueueType QueueType { get; set; }
        [JsonProperty("stats")]
        public object Stats { get; set; }
    }
}

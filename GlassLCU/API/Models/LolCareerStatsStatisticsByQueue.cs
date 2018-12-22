using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

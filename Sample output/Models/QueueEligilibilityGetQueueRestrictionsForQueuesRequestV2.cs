using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class QueueEligilibilityGetQueueRestrictionsForQueuesRequestV2
    {
        [JsonProperty("queueIds")]
        public int[] QueueIds { get; set; }
        [JsonProperty("queueRestrictionsToExclude")]
        public string[] QueueRestrictionsToExclude { get; set; }
        [JsonProperty("summonerIds")]
        public long[] SummonerIds { get; set; }
    }
}

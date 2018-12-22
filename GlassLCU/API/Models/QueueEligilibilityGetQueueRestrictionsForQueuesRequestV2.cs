using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
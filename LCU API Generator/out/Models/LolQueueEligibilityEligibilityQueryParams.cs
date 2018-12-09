using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolQueueEligibilityEligibilityQueryParams
    {
        [JsonProperty("queueIds")]
        public int[] QueueIds { get; set; }
        [JsonProperty("summonerIds")]
        public long[] SummonerIds { get; set; }
    }
}

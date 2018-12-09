using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolQueueEligibilityEligibility
    {
        [JsonProperty("eligible")]
        public bool Eligible { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("restrictions")]
        public LolQueueEligibilityEligibilityRestriction[] Restrictions { get; set; }
    }
}

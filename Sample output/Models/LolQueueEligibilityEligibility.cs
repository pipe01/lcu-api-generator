//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolFeaturedModesEligibility
    {
        [JsonProperty("eligible")]
        public bool Eligible { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("restrictions")]
        public LolFeaturedModesEligibilityRestriction[] Restrictions { get; set; }
    }
}

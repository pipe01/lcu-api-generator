using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolQueueEligibilityEligibilityRestriction
    {
        [JsonProperty("expiredTimestamp")]
        public long ExpiredTimestamp { get; set; }
        [JsonProperty("restrictionArgs")]
        public object RestrictionArgs { get; set; }
        [JsonProperty("restrictionCode")]
        public LolQueueEligibilityEligibilityRestrictionCode RestrictionCode { get; set; }
        [JsonProperty("summonerIds")]
        public long[] SummonerIds { get; set; }
    }
}

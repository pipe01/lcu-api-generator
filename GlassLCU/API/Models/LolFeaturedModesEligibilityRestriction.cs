using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolFeaturedModesEligibilityRestriction
    {
        [JsonProperty("expiredTimestamp")]
        public long ExpiredTimestamp { get; set; }
        [JsonProperty("restrictionArgs")]
        public object RestrictionArgs { get; set; }
        [JsonProperty("restrictionCode")]
        public LolFeaturedModesEligibilityRestrictionCode RestrictionCode { get; set; }
        [JsonProperty("summonerIds")]
        public long[] SummonerIds { get; set; }
    }
}

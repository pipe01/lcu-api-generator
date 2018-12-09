using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyEligibilityRestriction
    {
        [JsonProperty("expiredTimestamp")]
        public long ExpiredTimestamp { get; set; }
        [JsonProperty("restrictionArgs")]
        public object RestrictionArgs { get; set; }
        [JsonProperty("restrictionCode")]
        public LolLobbyEligibilityRestrictionCode RestrictionCode { get; set; }
        [JsonProperty("summonerIds")]
        public long[] SummonerIds { get; set; }
        [JsonProperty("summonerIdsString")]
        public string SummonerIdsString { get; set; }
    }
}

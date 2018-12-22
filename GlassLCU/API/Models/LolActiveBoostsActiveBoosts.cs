using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolActiveBoostsActiveBoosts
    {
        [JsonProperty("firstWinOfTheDayStartTime")]
        public string FirstWinOfTheDayStartTime { get; set; }
        [JsonProperty("ipBoostEndDate")]
        public string IpBoostEndDate { get; set; }
        [JsonProperty("ipBoostPerWinCount")]
        public int IpBoostPerWinCount { get; set; }
        [JsonProperty("ipLoyaltyBoost")]
        public int IpLoyaltyBoost { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("xpBoostEndDate")]
        public string XpBoostEndDate { get; set; }
        [JsonProperty("xpBoostPerWinCount")]
        public int XpBoostPerWinCount { get; set; }
        [JsonProperty("xpLoyaltyBoost")]
        public int XpLoyaltyBoost { get; set; }
    }
}

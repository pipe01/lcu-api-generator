using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class ActiveBoostsLcdsSummonerActiveBoostsDTO
    {
        [JsonProperty("ipBoostEndDate")]
        public long IpBoostEndDate { get; set; }
        [JsonProperty("ipBoostPerWinCount")]
        public int IpBoostPerWinCount { get; set; }
        [JsonProperty("ipLoyaltyBoost")]
        public int IpLoyaltyBoost { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("xpBoostEndDate")]
        public long XpBoostEndDate { get; set; }
        [JsonProperty("xpBoostPerWinCount")]
        public int XpBoostPerWinCount { get; set; }
        [JsonProperty("xpLoyaltyBoost")]
        public int XpLoyaltyBoost { get; set; }
    }
}

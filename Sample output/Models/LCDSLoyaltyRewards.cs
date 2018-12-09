using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LCDSLoyaltyRewards
    {
        [JsonProperty("champions")]
        public LCDSChampionReward[] Champions { get; set; }
        [JsonProperty("global")]
        public LCDSGlobalRewards Global { get; set; }
        [JsonProperty("ipBoost")]
        public int IpBoost { get; set; }
        [JsonProperty("xpBoost")]
        public int XpBoost { get; set; }
    }
}

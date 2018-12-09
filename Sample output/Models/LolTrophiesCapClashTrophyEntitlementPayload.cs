using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolTrophiesCapClashTrophyEntitlementPayload
    {
        [JsonProperty("rewardSpec")]
        public LolTrophiesClashV2TrophyRewardSpec RewardSpec { get; set; }
        [JsonProperty("rewardType")]
        public string RewardType { get; set; }
    }
}

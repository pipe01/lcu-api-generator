using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolBannersCapClashFlagEntitlementPayload
    {
        [JsonProperty("rewardSpec")]
        public LolBannersClashV2FlagRewardSpec RewardSpec { get; set; }
        [JsonProperty("rewardType")]
        public string RewardType { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolBannersCapClashFrameEntitlementPayload
    {
        [JsonProperty("rewardSpec")]
        public LolBannersClashV2FrameRewardSpec RewardSpec { get; set; }
        [JsonProperty("rewardType")]
        public string RewardType { get; set; }
    }
}

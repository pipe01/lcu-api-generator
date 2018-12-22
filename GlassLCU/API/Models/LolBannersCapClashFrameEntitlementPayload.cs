using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

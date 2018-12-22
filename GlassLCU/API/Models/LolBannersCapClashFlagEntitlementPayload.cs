using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

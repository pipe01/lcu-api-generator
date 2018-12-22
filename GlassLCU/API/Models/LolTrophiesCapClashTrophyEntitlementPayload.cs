using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class ClashRewardDefinition
    {
        [JsonProperty("rewardSpec")]
        public ClashRewardSpec RewardSpec { get; set; }
        [JsonProperty("rewardType")]
        public ClashRewardType RewardType { get; set; }
    }
}

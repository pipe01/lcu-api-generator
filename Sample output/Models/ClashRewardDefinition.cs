using Newtonsoft.Json;

namespace LCU_API_Generator
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

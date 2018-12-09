using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeRewardsRewardPack
    {
        [JsonProperty("delay")]
        public long Delay { get; set; }
        [JsonProperty("majorReward")]
        public LolNpeRewardsReward MajorReward { get; set; }
        [JsonProperty("minorRewards")]
        public LolNpeRewardsReward[] MinorRewards { get; set; }
        [JsonProperty("premiumReward")]
        public bool PremiumReward { get; set; }
        [JsonProperty("requirements")]
        public LolNpeRewardsRequirements Requirements { get; set; }
        [JsonProperty("rewardKey")]
        public string RewardKey { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("unlockTime")]
        public long UnlockTime { get; set; }
    }
}

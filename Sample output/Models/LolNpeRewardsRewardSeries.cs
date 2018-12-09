using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeRewardsRewardSeries
    {
        [JsonProperty("rewardPacks")]
        public LolNpeRewardsRewardPack[] RewardPacks { get; set; }
    }
}

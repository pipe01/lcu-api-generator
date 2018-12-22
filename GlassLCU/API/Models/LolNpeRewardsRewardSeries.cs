using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeRewardsRewardSeries
    {
        [JsonProperty("rewardPacks")]
        public LolNpeRewardsRewardPack[] RewardPacks { get; set; }
    }
}

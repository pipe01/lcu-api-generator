using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeRewardsAllRewards
    {
        [JsonProperty("level")]
        public LolNpeRewardsRewardSeries Level { get; set; }
        [JsonProperty("login")]
        public LolNpeRewardsRewardSeries Login { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

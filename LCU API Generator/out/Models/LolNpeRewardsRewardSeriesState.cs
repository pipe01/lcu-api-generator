using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeRewardsRewardSeriesState
    {
        [JsonProperty("allRewardsClaimed")]
        public bool AllRewardsClaimed { get; set; }
    }
}

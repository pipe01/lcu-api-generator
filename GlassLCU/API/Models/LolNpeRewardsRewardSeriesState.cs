using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeRewardsRewardSeriesState
    {
        [JsonProperty("allRewardsClaimed")]
        public bool AllRewardsClaimed { get; set; }
    }
}

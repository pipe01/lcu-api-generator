using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRankedRankedRewardsSplit
    {
        [JsonProperty("endTimeMillis")]
        public long EndTimeMillis { get; set; }
        [JsonProperty("rewards")]
        public LolRankedRankedReward[] Rewards { get; set; }
    }
}

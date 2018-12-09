using Newtonsoft.Json;

namespace LCU_API_Generator
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

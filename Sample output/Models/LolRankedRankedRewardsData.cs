using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRankedRankedRewardsData
    {
        [JsonProperty("currentSplit")]
        public int CurrentSplit { get; set; }
        [JsonProperty("playerPoints")]
        public int[] PlayerPoints { get; set; }
        [JsonProperty("seasonStartMillis")]
        public long SeasonStartMillis { get; set; }
        [JsonProperty("splits")]
        public LolRankedRankedRewardsSplit[] Splits { get; set; }
    }
}

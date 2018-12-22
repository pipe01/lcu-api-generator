using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRankedRankedRewardUpdate
    {
        [JsonProperty("deltaPercent")]
        public int DeltaPercent { get; set; }
        [JsonProperty("displayedRewardId")]
        public string DisplayedRewardId { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("oldPercent")]
        public int OldPercent { get; set; }
        [JsonProperty("pointsEarned")]
        public int PointsEarned { get; set; }
        [JsonProperty("rewardEarned")]
        public bool RewardEarned { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRankedRankedRewardUpdateDTO
    {
        [JsonProperty("currentSplit")]
        public int CurrentSplit { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("pointDelta")]
        public int PointDelta { get; set; }
        [JsonProperty("pointTotal")]
        public int PointTotal { get; set; }
        [JsonProperty("rewardEarned")]
        public string RewardEarned { get; set; }
    }
}
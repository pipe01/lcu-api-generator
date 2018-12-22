using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderMatchmakingLowPriorityData
    {
        [JsonProperty("bustedLeaverAccessToken")]
        public string BustedLeaverAccessToken { get; set; }
        [JsonProperty("penalizedSummonerIds")]
        public long[] PenalizedSummonerIds { get; set; }
        [JsonProperty("penaltyTime")]
        public float PenaltyTime { get; set; }
        [JsonProperty("penaltyTimeRemaining")]
        public float PenaltyTimeRemaining { get; set; }
    }
}

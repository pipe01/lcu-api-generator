using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyLobbyMatchmakingLowPriorityDataResource
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

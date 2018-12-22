using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class MatchmakingLcdsGameDTO
    {
        [JsonProperty("gameState")]
        public string GameState { get; set; }
        [JsonProperty("statusOfParticipants")]
        public string StatusOfParticipants { get; set; }
        [JsonProperty("teamOne")]
        public MatchmakingLcdsPlayerParticipant[] TeamOne { get; set; }
        [JsonProperty("teamTwo")]
        public MatchmakingLcdsPlayerParticipant[] TeamTwo { get; set; }
        [JsonProperty("terminatedCondition")]
        public string TerminatedCondition { get; set; }
    }
}

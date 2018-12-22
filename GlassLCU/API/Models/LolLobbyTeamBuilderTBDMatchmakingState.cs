using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderTBDMatchmakingState
    {
        [JsonProperty("backwardsTransitionReason")]
        public string BackwardsTransitionReason { get; set; }
        [JsonProperty("estimatedMatchmakingTimeMillis")]
        public long EstimatedMatchmakingTimeMillis { get; set; }
        [JsonProperty("timeInMatchmakingMillis")]
        public long TimeInMatchmakingMillis { get; set; }
    }
}

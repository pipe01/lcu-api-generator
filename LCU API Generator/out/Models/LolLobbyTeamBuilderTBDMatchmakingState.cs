using Newtonsoft.Json;

namespace LCU_API_Generator
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

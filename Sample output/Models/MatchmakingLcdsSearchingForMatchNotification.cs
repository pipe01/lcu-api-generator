using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class MatchmakingLcdsSearchingForMatchNotification
    {
        [JsonProperty("joinedQueues")]
        public MatchmakingLcdsQueueInfo[] JoinedQueues { get; set; }
        [JsonProperty("playerJoinFailures")]
        public object[] PlayerJoinFailures { get; set; }
    }
}

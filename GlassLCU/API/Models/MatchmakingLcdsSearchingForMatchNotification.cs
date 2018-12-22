using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

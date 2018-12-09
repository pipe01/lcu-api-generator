using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LeaverBusterLcdsMatchmakingNotification
    {
        [JsonProperty("playerJoinFailures")]
        public object[] PlayerJoinFailures { get; set; }
    }
}

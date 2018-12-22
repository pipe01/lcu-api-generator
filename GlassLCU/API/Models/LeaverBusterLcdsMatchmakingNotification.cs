using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LeaverBusterLcdsMatchmakingNotification
    {
        [JsonProperty("playerJoinFailures")]
        public object[] PlayerJoinFailures { get; set; }
    }
}

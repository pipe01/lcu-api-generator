//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMatchmakingPlayerStatus
    {
        [JsonProperty("currentLobbyStatus")]
        public LolMatchmakingLobbyStatus CurrentLobbyStatus { get; set; }
        [JsonProperty("lastQueuedLobbyStatus")]
        public LolMatchmakingLobbyStatus LastQueuedLobbyStatus { get; set; }
    }
}

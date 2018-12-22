using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampSelectLegacyPlayerStatus
    {
        [JsonProperty("currentLobbyStatus")]
        public LolChampSelectLegacyLobbyStatus CurrentLobbyStatus { get; set; }
        [JsonProperty("lastQueuedLobbyStatus")]
        public LolChampSelectLegacyLobbyStatus LastQueuedLobbyStatus { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
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

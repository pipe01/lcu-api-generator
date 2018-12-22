using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyLobbyCustomChampSelectStartResponse
    {
        [JsonProperty("failedPlayers")]
        public LolLobbyLobbyCustomFailedPlayer[] FailedPlayers { get; set; }
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}

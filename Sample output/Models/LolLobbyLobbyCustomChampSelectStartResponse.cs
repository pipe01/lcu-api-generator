//Auto-generated by https://github.com/pipe01/lcu-api-generator
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

using Newtonsoft.Json;

namespace LCU_API_Generator
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

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyLobbyCustomJoinParameters
    {
        [JsonProperty("asSpectator")]
        public bool AsSpectator { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}

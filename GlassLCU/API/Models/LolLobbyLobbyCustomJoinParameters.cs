using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

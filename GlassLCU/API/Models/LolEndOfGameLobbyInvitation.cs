using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEndOfGameLobbyInvitation
    {
        [JsonProperty("state")]
        public string State { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolEndOfGameLobbyInvitation
    {
        [JsonProperty("state")]
        public string State { get; set; }
    }
}

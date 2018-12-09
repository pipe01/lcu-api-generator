using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyPartyStatusDto
    {
        [JsonProperty("eogPlayers")]
        public string[] EogPlayers { get; set; }
        [JsonProperty("leftPlayers")]
        public string[] LeftPlayers { get; set; }
        [JsonProperty("partySize")]
        public int PartySize { get; set; }
        [JsonProperty("readyPlayers")]
        public string[] ReadyPlayers { get; set; }
    }
}

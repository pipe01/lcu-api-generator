using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathLobbyDto
    {
        [JsonProperty("gameConfig")]
        public LolNpeTutorialPathLobbyGameConfigDto GameConfig { get; set; }
        [JsonProperty("partyId")]
        public string PartyId { get; set; }
    }
}

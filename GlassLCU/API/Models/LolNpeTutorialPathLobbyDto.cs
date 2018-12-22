using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyPremadePartyDto
    {
        [JsonProperty("partyId")]
        public string PartyId { get; set; }
        [JsonProperty("players")]
        public object Players { get; set; }
    }
}

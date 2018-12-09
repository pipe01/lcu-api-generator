using Newtonsoft.Json;

namespace LCU_API_Generator
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

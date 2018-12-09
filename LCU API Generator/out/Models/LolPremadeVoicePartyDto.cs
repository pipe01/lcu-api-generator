using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPremadeVoicePartyDto
    {
        [JsonProperty("partyId")]
        public string PartyId { get; set; }
        [JsonProperty("players")]
        public object Players { get; set; }
    }
}

//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

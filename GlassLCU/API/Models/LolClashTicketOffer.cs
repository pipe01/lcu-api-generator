using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashTicketOffer
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }
        [JsonProperty("isAccepted")]
        public bool IsAccepted { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

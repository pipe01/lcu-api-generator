using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class TicketOfferDTO
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("offerPlayerId")]
        public long OfferPlayerId { get; set; }
        [JsonProperty("receivePlayerId")]
        public long ReceivePlayerId { get; set; }
        [JsonProperty("ticketOfferState")]
        public TicketOfferState TicketOfferState { get; set; }
    }
}

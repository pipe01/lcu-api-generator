using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashSetTicketRequest
    {
        [JsonProperty("ticketAmount")]
        public int TicketAmount { get; set; }
    }
}

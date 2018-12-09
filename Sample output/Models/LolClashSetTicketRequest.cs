using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashSetTicketRequest
    {
        [JsonProperty("ticketAmount")]
        public int TicketAmount { get; set; }
    }
}

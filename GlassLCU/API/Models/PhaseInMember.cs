using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PhaseInMember
    {
        [JsonProperty("bet")]
        public int Bet { get; set; }
        [JsonProperty("pendingPay")]
        public int PendingPay { get; set; }
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
        [JsonProperty("selfBet")]
        public int SelfBet { get; set; }
    }
}
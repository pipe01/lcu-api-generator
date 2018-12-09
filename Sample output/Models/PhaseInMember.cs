using Newtonsoft.Json;

namespace LCU_API_Generator
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

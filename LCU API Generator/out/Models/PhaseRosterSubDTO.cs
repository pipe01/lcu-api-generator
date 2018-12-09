using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PhaseRosterSubDTO
    {
        [JsonProperty("bet")]
        public int Bet { get; set; }
        [JsonProperty("pay")]
        public int Pay { get; set; }
        [JsonProperty("pendingPay")]
        public int PendingPay { get; set; }
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
        [JsonProperty("position")]
        public Position Position { get; set; }
        [JsonProperty("replacedPlayerId")]
        public long ReplacedPlayerId { get; set; }
        [JsonProperty("selfBet")]
        public int SelfBet { get; set; }
        [JsonProperty("subState")]
        public SubState SubState { get; set; }
        [JsonProperty("tier")]
        public int Tier { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PendingRosterMemberDTO
    {
        [JsonProperty("bet")]
        public int Bet { get; set; }
        [JsonProperty("joinTime")]
        public long JoinTime { get; set; }
        [JsonProperty("memberState")]
        public PendingRosterMemberState MemberState { get; set; }
        [JsonProperty("pendingPay")]
        public int PendingPay { get; set; }
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
        [JsonProperty("position")]
        public Position Position { get; set; }
        [JsonProperty("selfBet")]
        public int SelfBet { get; set; }
        [JsonProperty("tier")]
        public int Tier { get; set; }
    }
}

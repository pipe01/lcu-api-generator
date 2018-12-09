using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RosterMemberDTO
    {
        [JsonProperty("currentBid")]
        public int CurrentBid { get; set; }
        [JsonProperty("joinTime")]
        public long JoinTime { get; set; }
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
        [JsonProperty("position")]
        public Position Position { get; set; }
        [JsonProperty("rosterId")]
        public long RosterId { get; set; }
        [JsonProperty("tier")]
        public int Tier { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class BracketMatch
    {
        [JsonProperty("forfeitRosterId")]
        public long ForfeitRosterId { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("gameStartTime")]
        public long GameStartTime { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("loserBracket")]
        public bool LoserBracket { get; set; }
        [JsonProperty("order")]
        public int Order { get; set; }
        [JsonProperty("rosterId1")]
        public long RosterId1 { get; set; }
        [JsonProperty("rosterId2")]
        public long RosterId2 { get; set; }
        [JsonProperty("round")]
        public int Round { get; set; }
        [JsonProperty("roundStartTime")]
        public long RoundStartTime { get; set; }
        [JsonProperty("status")]
        public ClientBracketMatchStatus Status { get; set; }
        [JsonProperty("winnerId")]
        public long WinnerId { get; set; }
    }
}

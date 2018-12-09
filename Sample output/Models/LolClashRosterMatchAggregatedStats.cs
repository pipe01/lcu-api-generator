using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashRosterMatchAggregatedStats
    {
        [JsonProperty("durationMs")]
        public long DurationMs { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("kills")]
        public int Kills { get; set; }
        [JsonProperty("loserBracket")]
        public bool LoserBracket { get; set; }
        [JsonProperty("opponentIconColorId")]
        public int OpponentIconColorId { get; set; }
        [JsonProperty("opponentIconId")]
        public int OpponentIconId { get; set; }
        [JsonProperty("opponentKills")]
        public int OpponentKills { get; set; }
        [JsonProperty("opponentShortName")]
        public string OpponentShortName { get; set; }
        [JsonProperty("playerChampionIds")]
        public object PlayerChampionIds { get; set; }
        [JsonProperty("round")]
        public int Round { get; set; }
        [JsonProperty("win")]
        public bool Win { get; set; }
    }
}

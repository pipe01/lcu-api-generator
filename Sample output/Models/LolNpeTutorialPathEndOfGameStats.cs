using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathEndOfGameStats
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("gameType")]
        public string GameType { get; set; }
        [JsonProperty("teams")]
        public LolNpeTutorialPathEndOfGameTeam[] Teams { get; set; }
    }
}

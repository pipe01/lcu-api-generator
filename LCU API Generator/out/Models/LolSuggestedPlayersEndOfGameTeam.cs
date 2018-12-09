using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSuggestedPlayersEndOfGameTeam
    {
        [JsonProperty("isWinningTeam")]
        public bool IsWinningTeam { get; set; }
        [JsonProperty("players")]
        public LolSuggestedPlayersEndOfGamePlayer[] Players { get; set; }
    }
}

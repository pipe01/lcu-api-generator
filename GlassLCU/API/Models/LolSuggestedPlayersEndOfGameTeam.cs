using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

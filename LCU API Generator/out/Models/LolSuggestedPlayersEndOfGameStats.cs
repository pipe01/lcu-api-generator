using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSuggestedPlayersEndOfGameStats
    {
        [JsonProperty("teams")]
        public LolSuggestedPlayersEndOfGameTeam[] Teams { get; set; }
    }
}

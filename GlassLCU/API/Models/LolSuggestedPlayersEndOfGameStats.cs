using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolSuggestedPlayersEndOfGameStats
    {
        [JsonProperty("teams")]
        public LolSuggestedPlayersEndOfGameTeam[] Teams { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LeaguesLcdsSummonerLeaguesDTO
    {
        [JsonProperty("summonerLeagues")]
        public LeaguesLcdsSummonerLeagueListDTO[] SummonerLeagues { get; set; }
    }
}

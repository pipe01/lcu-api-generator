using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LeaguesLcdsSummonerLeagueItemsDTO
    {
        [JsonProperty("summonerLeagues")]
        public LeaguesLcdsLeagueItemDTO[] SummonerLeagues { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RankedSummonerLeaguesDTO
    {
        [JsonProperty("summonerLeagues")]
        public RankedLeagueListDTO[] SummonerLeagues { get; set; }
    }
}

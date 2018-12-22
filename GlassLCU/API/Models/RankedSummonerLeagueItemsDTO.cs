using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RankedSummonerLeagueItemsDTO
    {
        [JsonProperty("summonerLeagues")]
        public RankedLeagueItemDTO[] SummonerLeagues { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRankedSignedSummonerLeagueItemsDTO
    {
        [JsonProperty("summonerLeagues")]
        public LolRankedSignedLeagueItemDTO[] SummonerLeagues { get; set; }
    }
}

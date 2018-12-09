using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RankedSummonerLeagueItemsDTO
    {
        [JsonProperty("summonerLeagues")]
        public RankedLeagueItemDTO[] SummonerLeagues { get; set; }
    }
}

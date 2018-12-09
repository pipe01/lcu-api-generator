using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RankedSummonerLeaguesDTO
    {
        [JsonProperty("summonerLeagues")]
        public RankedLeagueListDTO[] SummonerLeagues { get; set; }
    }
}

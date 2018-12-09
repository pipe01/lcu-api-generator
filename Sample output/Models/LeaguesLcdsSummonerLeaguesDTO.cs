using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LeaguesLcdsSummonerLeaguesDTO
    {
        [JsonProperty("summonerLeagues")]
        public LeaguesLcdsSummonerLeagueListDTO[] SummonerLeagues { get; set; }
    }
}

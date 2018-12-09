using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LeaguesLcdsSummonerLeagueItemsDTO
    {
        [JsonProperty("summonerLeagues")]
        public LeaguesLcdsLeagueItemDTO[] SummonerLeagues { get; set; }
    }
}

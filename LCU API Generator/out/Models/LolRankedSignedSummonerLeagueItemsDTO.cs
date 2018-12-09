using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRankedSignedSummonerLeagueItemsDTO
    {
        [JsonProperty("summonerLeagues")]
        public LolRankedSignedLeagueItemDTO[] SummonerLeagues { get; set; }
    }
}

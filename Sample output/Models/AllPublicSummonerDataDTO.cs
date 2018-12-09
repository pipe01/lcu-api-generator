using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class AllPublicSummonerDataDTO
    {
        [JsonProperty("summoner")]
        public BasePublicSummonerDTO Summoner { get; set; }
        [JsonProperty("summonerLevelAndPoints")]
        public SummonerLevelAndPoints SummonerLevelAndPoints { get; set; }
    }
}

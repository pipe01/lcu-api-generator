using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class AllSummonerData
    {
        [JsonProperty("summoner")]
        public PrivateSummonerDTO Summoner { get; set; }
        [JsonProperty("summonerLevelAndPoints")]
        public SummonerLevelAndPoints SummonerLevelAndPoints { get; set; }
    }
}

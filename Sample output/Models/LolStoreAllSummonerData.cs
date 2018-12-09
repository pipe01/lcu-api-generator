using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolStoreAllSummonerData
    {
        [JsonProperty("summoner")]
        public LolStoreSummoner Summoner { get; set; }
        [JsonProperty("summonerLevelAndPoints")]
        public LolStoreSummonerLevelAndPoints SummonerLevelAndPoints { get; set; }
    }
}

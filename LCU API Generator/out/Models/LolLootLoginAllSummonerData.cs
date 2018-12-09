using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLootLoginAllSummonerData
    {
        [JsonProperty("summonerLevelAndPoints")]
        public LolLootLoginSummonerLevelAndPoints SummonerLevelAndPoints { get; set; }
    }
}

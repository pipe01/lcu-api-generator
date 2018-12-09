using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolEndOfGameLoginSummonerData
    {
        [JsonProperty("summonerLevelAndPoints")]
        public LolEndOfGameLoginSummonerLevelAndPoints SummonerLevelAndPoints { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLootLoginSummonerLevelAndPoints
    {
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}
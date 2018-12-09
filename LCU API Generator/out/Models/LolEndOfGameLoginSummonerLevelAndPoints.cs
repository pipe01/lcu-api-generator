using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolEndOfGameLoginSummonerLevelAndPoints
    {
        [JsonProperty("expPoints")]
        public long ExpPoints { get; set; }
        [JsonProperty("expToNextLevel")]
        public long ExpToNextLevel { get; set; }
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}

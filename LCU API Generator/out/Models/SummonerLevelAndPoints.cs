using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class SummonerLevelAndPoints
    {
        [JsonProperty("expPoints")]
        public long ExpPoints { get; set; }
        [JsonProperty("expToNextLevel")]
        public long ExpToNextLevel { get; set; }
        [JsonProperty("sumId")]
        public long SumId { get; set; }
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}

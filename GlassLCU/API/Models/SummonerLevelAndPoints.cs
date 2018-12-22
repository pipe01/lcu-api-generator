using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
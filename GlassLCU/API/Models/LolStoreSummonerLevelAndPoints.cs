using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolStoreSummonerLevelAndPoints
    {
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}

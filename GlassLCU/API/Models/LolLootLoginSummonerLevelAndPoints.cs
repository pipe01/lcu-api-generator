using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootLoginSummonerLevelAndPoints
    {
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}

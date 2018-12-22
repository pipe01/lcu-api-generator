using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootLoginAllSummonerData
    {
        [JsonProperty("summonerLevelAndPoints")]
        public LolLootLoginSummonerLevelAndPoints SummonerLevelAndPoints { get; set; }
    }
}

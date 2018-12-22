using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEndOfGameLoginSummonerData
    {
        [JsonProperty("summonerLevelAndPoints")]
        public LolEndOfGameLoginSummonerLevelAndPoints SummonerLevelAndPoints { get; set; }
    }
}

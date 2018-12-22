using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolStoreAllSummonerData
    {
        [JsonProperty("summoner")]
        public LolStoreSummoner Summoner { get; set; }
        [JsonProperty("summonerLevelAndPoints")]
        public LolStoreSummonerLevelAndPoints SummonerLevelAndPoints { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class AllSummonerData
    {
        [JsonProperty("summoner")]
        public PrivateSummonerDTO Summoner { get; set; }
        [JsonProperty("summonerLevelAndPoints")]
        public SummonerLevelAndPoints SummonerLevelAndPoints { get; set; }
    }
}

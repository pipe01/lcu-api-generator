using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class AllPublicSummonerDataDTO
    {
        [JsonProperty("summoner")]
        public BasePublicSummonerDTO Summoner { get; set; }
        [JsonProperty("summonerLevelAndPoints")]
        public SummonerLevelAndPoints SummonerLevelAndPoints { get; set; }
    }
}

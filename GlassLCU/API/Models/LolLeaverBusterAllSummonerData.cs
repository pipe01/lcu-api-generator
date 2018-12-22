using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLeaverBusterAllSummonerData
    {
        [JsonProperty("summoner")]
        public LolLeaverBusterSummoner Summoner { get; set; }
    }
}

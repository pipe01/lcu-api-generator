using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLeaverBusterAllSummonerData
    {
        [JsonProperty("summoner")]
        public LolLeaverBusterSummoner Summoner { get; set; }
    }
}

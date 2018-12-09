using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolContentTargetingSummoner
    {
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}

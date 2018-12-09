using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class ChampSelectLcdsRollResult
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("pointSummary")]
        public ChampSelectLcdsPointSummary PointSummary { get; set; }
    }
}

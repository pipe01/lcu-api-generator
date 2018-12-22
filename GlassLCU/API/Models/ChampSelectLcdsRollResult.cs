using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

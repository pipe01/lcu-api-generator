using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LeaguesLcdsAggregatedStat
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("statType")]
        public string StatType { get; set; }
        [JsonProperty("value")]
        public float Value { get; set; }
    }
}

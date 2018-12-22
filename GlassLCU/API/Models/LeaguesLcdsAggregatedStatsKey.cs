using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LeaguesLcdsAggregatedStatsKey
    {
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("userId")]
        public long UserId { get; set; }
    }
}

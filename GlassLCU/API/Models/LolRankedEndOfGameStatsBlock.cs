using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRankedEndOfGameStatsBlock
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolActiveBoostsEndOfGameStats
    {
        [JsonProperty("timeUntilNextFirstWinBonus")]
        public long TimeUntilNextFirstWinBonus { get; set; }
    }
}

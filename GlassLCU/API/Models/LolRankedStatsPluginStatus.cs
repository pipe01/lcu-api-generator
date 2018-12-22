using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRankedStatsPluginStatus
    {
        [JsonProperty("ready")]
        public bool Ready { get; set; }
    }
}

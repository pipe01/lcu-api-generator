using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolHighlightsHighlightsDynamicConfig
    {
        [JsonProperty("Enabled")]
        public bool Enabled { get; set; }
    }
}

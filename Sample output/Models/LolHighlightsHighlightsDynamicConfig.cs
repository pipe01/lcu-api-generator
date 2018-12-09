using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolHighlightsHighlightsDynamicConfig
    {
        [JsonProperty("Enabled")]
        public bool Enabled { get; set; }
    }
}

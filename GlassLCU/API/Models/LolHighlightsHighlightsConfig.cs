using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolHighlightsHighlightsConfig
    {
        [JsonProperty("invalidHighlightNameCharacters")]
        public string InvalidHighlightNameCharacters { get; set; }
        [JsonProperty("isHighlightsEnabled")]
        public bool IsHighlightsEnabled { get; set; }
    }
}

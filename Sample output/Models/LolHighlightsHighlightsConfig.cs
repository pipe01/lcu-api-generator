using Newtonsoft.Json;

namespace LCU_API_Generator
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

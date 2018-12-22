using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class SanitizerSanitizerStatus
    {
        [JsonProperty("breakingCharsCount")]
        public int BreakingCharsCount { get; set; }
        [JsonProperty("filteredWordCountsByLevel")]
        public object FilteredWordCountsByLevel { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("projectedCharsCount")]
        public int ProjectedCharsCount { get; set; }
        [JsonProperty("ready")]
        public bool Ready { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }
        [JsonProperty("whitelistedWordCountsByLevel")]
        public object WhitelistedWordCountsByLevel { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolHighlightsHighlightsSettingsResource
    {
        [JsonProperty("data")]
        public LolHighlightsHighlightsSettingsData Data { get; set; }
    }
}

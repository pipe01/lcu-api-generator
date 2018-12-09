using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolHighlightsHighlightsSettingsResource
    {
        [JsonProperty("data")]
        public LolHighlightsHighlightsSettingsData Data { get; set; }
    }
}

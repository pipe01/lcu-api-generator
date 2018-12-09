using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolHighlightsHighlightsSettingsData
    {
        [JsonProperty("highlights-folder-path")]
        public string Highlights_folder_path { get; set; }
    }
}

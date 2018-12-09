using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolReplaysReplaysSettingsData
    {
        [JsonProperty("highlights-folder-path")]
        public string Highlights_folder_path { get; set; }
        [JsonProperty("replays-folder-path")]
        public string Replays_folder_path { get; set; }
    }
}

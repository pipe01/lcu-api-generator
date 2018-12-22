using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

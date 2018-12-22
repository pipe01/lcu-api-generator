using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGameflowReplaysSettingsData
    {
        [JsonProperty("highlights-folder-path")]
        public string Highlights_folder_path { get; set; }
    }
}

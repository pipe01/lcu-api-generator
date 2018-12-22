using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class ReplayMetadataV2
    {
        [JsonProperty("fileSize")]
        public int FileSize { get; set; }
        [JsonProperty("gameVersion")]
        public string GameVersion { get; set; }
    }
}

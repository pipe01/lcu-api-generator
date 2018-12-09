using Newtonsoft.Json;

namespace LCU_API_Generator
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

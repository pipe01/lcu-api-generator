using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolReplaysRoflFileMetadata
    {
        [JsonProperty("gameLength")]
        public int GameLength { get; set; }
        [JsonProperty("gameVersion")]
        public string GameVersion { get; set; }
        [JsonProperty("lastGameChunkId")]
        public int LastGameChunkId { get; set; }
        [JsonProperty("lastKeyFrameId")]
        public int LastKeyFrameId { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolReplaysReplayMetadata
    {
        [JsonProperty("downloadProgress")]
        public int DownloadProgress { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("state")]
        public LolReplaysMetadataState State { get; set; }
    }
}

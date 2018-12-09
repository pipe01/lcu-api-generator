using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class MultipleReplayMetadataResponseItemV2
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("metadata")]
        public ReplayMetadataV2 Metadata { get; set; }
        [JsonProperty("status")]
        public ReplayResponseStatus Status { get; set; }
    }
}

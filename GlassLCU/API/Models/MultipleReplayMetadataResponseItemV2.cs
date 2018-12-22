using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

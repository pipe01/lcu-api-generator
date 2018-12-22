using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class MultipleReplayMetadataResponseV2
    {
        [JsonProperty("metadataResponses")]
        public MultipleReplayMetadataResponseItemV2[] MetadataResponses { get; set; }
    }
}

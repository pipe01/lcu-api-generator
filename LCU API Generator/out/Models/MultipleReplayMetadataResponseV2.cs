using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class MultipleReplayMetadataResponseV2
    {
        [JsonProperty("metadataResponses")]
        public MultipleReplayMetadataResponseItemV2[] MetadataResponses { get; set; }
    }
}

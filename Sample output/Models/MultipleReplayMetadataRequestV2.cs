using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class MultipleReplayMetadataRequestV2
    {
        [JsonProperty("gameIds")]
        public long[] GameIds { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
    }
}

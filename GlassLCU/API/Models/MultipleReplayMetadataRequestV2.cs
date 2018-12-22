using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

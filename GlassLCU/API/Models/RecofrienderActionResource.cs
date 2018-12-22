using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RecofrienderActionResource
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("action")]
        public string Action { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
    }
}

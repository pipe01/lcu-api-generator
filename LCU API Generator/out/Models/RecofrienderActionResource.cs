using Newtonsoft.Json;

namespace LCU_API_Generator
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

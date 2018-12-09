using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLoginRegionStatus
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("isLQFallbackAllowed")]
        public bool IsLQFallbackAllowed { get; set; }
        [JsonProperty("isUserInfoEnabled")]
        public bool IsUserInfoEnabled { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
    }
}

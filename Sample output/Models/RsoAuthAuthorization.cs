using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RsoAuthAuthorization
    {
        [JsonProperty("currentAccountId")]
        public long CurrentAccountId { get; set; }
        [JsonProperty("currentPlatformId")]
        public string CurrentPlatformId { get; set; }
        [JsonProperty("subject")]
        public string Subject { get; set; }
    }
}

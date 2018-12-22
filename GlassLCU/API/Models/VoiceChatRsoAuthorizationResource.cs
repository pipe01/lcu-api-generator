using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class VoiceChatRsoAuthorizationResource
    {
        [JsonProperty("currentAccountId")]
        public long CurrentAccountId { get; set; }
        [JsonProperty("currentPlatformId")]
        public string CurrentPlatformId { get; set; }
        [JsonProperty("subject")]
        public string Subject { get; set; }
    }
}

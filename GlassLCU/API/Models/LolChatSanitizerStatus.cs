using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChatSanitizerStatus
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("platformID")]
        public string PlatformID { get; set; }
        [JsonProperty("ready")]
        public bool Ready { get; set; }
    }
}

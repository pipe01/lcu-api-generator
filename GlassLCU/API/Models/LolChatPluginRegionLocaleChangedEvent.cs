using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChatPluginRegionLocaleChangedEvent
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }
    }
}

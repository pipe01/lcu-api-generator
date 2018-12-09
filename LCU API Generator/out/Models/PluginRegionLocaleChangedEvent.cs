using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PluginRegionLocaleChangedEvent
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }
    }
}
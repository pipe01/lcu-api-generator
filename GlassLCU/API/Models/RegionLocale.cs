using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RegionLocale
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }
        [JsonProperty("webLanguage")]
        public string WebLanguage { get; set; }
        [JsonProperty("webRegion")]
        public string WebRegion { get; set; }
    }
}

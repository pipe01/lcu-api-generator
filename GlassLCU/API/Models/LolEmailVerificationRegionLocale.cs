using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEmailVerificationRegionLocale
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

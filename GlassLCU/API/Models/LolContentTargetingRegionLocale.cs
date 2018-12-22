using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolContentTargetingRegionLocale
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }
    }
}

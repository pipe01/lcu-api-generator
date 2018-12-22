using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolContentTargetingContentTargetingLocaleResponse
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }
    }
}

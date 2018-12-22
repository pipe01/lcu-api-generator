using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRegaliaRegaliaPreferences
    {
        [JsonProperty("preferredBannerType")]
        public string PreferredBannerType { get; set; }
        [JsonProperty("preferredCrestType")]
        public string PreferredCrestType { get; set; }
    }
}

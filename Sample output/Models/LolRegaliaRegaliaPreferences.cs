using Newtonsoft.Json;

namespace LCU_API_Generator
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

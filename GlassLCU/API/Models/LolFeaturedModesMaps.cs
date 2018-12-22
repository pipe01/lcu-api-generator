using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolFeaturedModesMaps
    {
        [JsonProperty("assets")]
        public object Assets { get; set; }
        [JsonProperty("gameModeName")]
        public string GameModeName { get; set; }
        [JsonProperty("isRGM")]
        public bool IsRGM { get; set; }
    }
}

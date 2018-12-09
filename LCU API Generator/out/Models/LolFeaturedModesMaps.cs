using Newtonsoft.Json;

namespace LCU_API_Generator
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

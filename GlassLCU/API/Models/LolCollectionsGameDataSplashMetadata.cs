using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCollectionsGameDataSplashMetadata
    {
        [JsonProperty("CalculatedColor")]
        public string CalculatedColor { get; set; }
        [JsonProperty("OverrideColor")]
        public string OverrideColor { get; set; }
    }
}

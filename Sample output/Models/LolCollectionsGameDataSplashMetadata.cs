using Newtonsoft.Json;

namespace LCU_API_Generator
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

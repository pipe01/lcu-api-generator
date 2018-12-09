using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class SeriesMediaDTO
    {
        [JsonProperty("accentColor")]
        public string AccentColor { get; set; }
        [JsonProperty("backgroundImageLargeUrl")]
        public string BackgroundImageLargeUrl { get; set; }
        [JsonProperty("backgroundImageSmallUrl")]
        public string BackgroundImageSmallUrl { get; set; }
        [JsonProperty("backgroundUrl")]
        public string BackgroundUrl { get; set; }
    }
}

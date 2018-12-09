using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class ThemeVp
    {
        [JsonProperty("themeId")]
        public int ThemeId { get; set; }
        [JsonProperty("themeVp")]
        public int ThemeVp2 { get; set; }
    }
}

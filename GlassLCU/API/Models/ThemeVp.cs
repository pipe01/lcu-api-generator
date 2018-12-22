using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

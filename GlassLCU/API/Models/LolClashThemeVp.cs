using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashThemeVp
    {
        [JsonProperty("themeId")]
        public int ThemeId { get; set; }
        [JsonProperty("vp")]
        public int Vp { get; set; }
    }
}

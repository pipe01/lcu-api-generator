using Newtonsoft.Json;

namespace LCU_API_Generator
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

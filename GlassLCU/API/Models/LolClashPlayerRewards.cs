using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashPlayerRewards
    {
        [JsonProperty("seasonVp")]
        public int SeasonVp { get; set; }
        [JsonProperty("themeVp")]
        public LolClashThemeVp[] ThemeVp { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
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

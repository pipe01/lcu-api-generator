using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeRewardsAccountSettingsData
    {
        [JsonProperty("login")]
        public LolNpeRewardsLoginSeriesSettings Login { get; set; }
    }
}

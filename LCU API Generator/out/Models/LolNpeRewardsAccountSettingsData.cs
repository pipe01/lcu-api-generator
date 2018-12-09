using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeRewardsAccountSettingsData
    {
        [JsonProperty("login")]
        public LolNpeRewardsLoginSeriesSettings Login { get; set; }
    }
}

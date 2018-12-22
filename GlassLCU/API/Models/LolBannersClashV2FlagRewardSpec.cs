using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolBannersClashV2FlagRewardSpec
    {
        [JsonProperty("level")]
        public string Level { get; set; }
        [JsonProperty("seasonId")]
        public string SeasonId { get; set; }
        [JsonProperty("theme")]
        public string Theme { get; set; }
    }
}
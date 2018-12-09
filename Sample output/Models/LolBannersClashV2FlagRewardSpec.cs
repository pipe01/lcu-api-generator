using Newtonsoft.Json;

namespace LCU_API_Generator
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

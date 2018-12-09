using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolBannersBannerFlag
    {
        [JsonProperty("earnedDateIso8601")]
        public string EarnedDateIso8601 { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("level")]
        public long Level { get; set; }
        [JsonProperty("seasonId")]
        public long SeasonId { get; set; }
        [JsonProperty("theme")]
        public string Theme { get; set; }
    }
}

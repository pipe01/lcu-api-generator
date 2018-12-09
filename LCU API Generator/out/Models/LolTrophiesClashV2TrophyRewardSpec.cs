using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolTrophiesClashV2TrophyRewardSpec
    {
        [JsonProperty("bracket")]
        public string Bracket { get; set; }
        [JsonProperty("seasonId")]
        public string SeasonId { get; set; }
        [JsonProperty("theme")]
        public string Theme { get; set; }
        [JsonProperty("tier")]
        public string Tier { get; set; }
    }
}

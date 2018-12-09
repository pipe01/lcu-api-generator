using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolTrophiesTrophyProfileData
    {
        [JsonProperty("bracket")]
        public long Bracket { get; set; }
        [JsonProperty("seasonId")]
        public long SeasonId { get; set; }
        [JsonProperty("theme")]
        public string Theme { get; set; }
        [JsonProperty("tier")]
        public long Tier { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
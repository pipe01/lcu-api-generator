using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashClubsSummoner
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

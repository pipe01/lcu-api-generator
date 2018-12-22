using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClubsPublicClubTag
    {
        [JsonProperty("clubName")]
        public string ClubName { get; set; }
        [JsonProperty("clubTag")]
        public string ClubTag { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
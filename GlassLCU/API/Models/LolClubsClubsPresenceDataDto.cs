using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClubsClubsPresenceDataDto
    {
        [JsonProperty("clubName")]
        public string ClubName { get; set; }
        [JsonProperty("clubTag")]
        public string ClubTag { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClubsClubReferenceDto
    {
        [JsonProperty("clubKey")]
        public string ClubKey { get; set; }
        [JsonProperty("clubName")]
        public string ClubName { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClubsPlayerMembershipPreferencesDto
    {
        [JsonProperty("primaryActiveClubKey")]
        public string PrimaryActiveClubKey { get; set; }
        [JsonProperty("shareClubAffiliation")]
        public bool ShareClubAffiliation { get; set; }
    }
}

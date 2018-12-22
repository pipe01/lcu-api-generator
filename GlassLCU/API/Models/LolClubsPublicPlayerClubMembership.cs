using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClubsPublicPlayerClubMembership
    {
        [JsonProperty("activeClubs")]
        public LolClubsPublicPlayerClub[] ActiveClubs { get; set; }
        [JsonProperty("info")]
        public LolClubsPublicClubPlayer Info { get; set; }
        [JsonProperty("preferences")]
        public LolClubsPublicClubPreferences Preferences { get; set; }
        [JsonProperty("secureClubPresenceInfoString")]
        public string SecureClubPresenceInfoString { get; set; }
    }
}

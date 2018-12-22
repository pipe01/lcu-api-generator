using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClubsPlayerClubMembership
    {
        [JsonProperty("activeClubs")]
        public LolClubsPlayerClub[] ActiveClubs { get; set; }
        [JsonProperty("clubsServerConfig")]
        public LolClubsClubsConfig ClubsServerConfig { get; set; }
        [JsonProperty("info")]
        public LolClubsClubPlayer Info { get; set; }
        [JsonProperty("pendingInvites")]
        public LolClubsClubInvite[] PendingInvites { get; set; }
        [JsonProperty("preferences")]
        public LolClubsClubPreferences Preferences { get; set; }
        [JsonProperty("removedClubs")]
        public LolClubsClub[] RemovedClubs { get; set; }
        [JsonProperty("revokedInviteClubs")]
        public LolClubsClub[] RevokedInviteClubs { get; set; }
        [JsonProperty("secureClubPresenceInfoString")]
        public string SecureClubPresenceInfoString { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsPlayerMembershipDto
    {
        [JsonProperty("activeClubs")]
        public LolClubsClubDto[] ActiveClubs { get; set; }
        [JsonProperty("clubsServerConfig")]
        public LolClubsClubsServerConfigDto ClubsServerConfig { get; set; }
        [JsonProperty("pendingInvites")]
        public LolClubsMembershipInviteDto[] PendingInvites { get; set; }
        [JsonProperty("player")]
        public LolClubsPlayerInfoDto Player { get; set; }
        [JsonProperty("playerClubPreferences")]
        public LolClubsPlayerMembershipPreferencesDto PlayerClubPreferences { get; set; }
        [JsonProperty("removedClubs")]
        public LolClubsClubReferenceDto[] RemovedClubs { get; set; }
        [JsonProperty("resourceUri")]
        public string ResourceUri { get; set; }
        [JsonProperty("revokedInviteClubs")]
        public LolClubsClubReferenceDto[] RevokedInviteClubs { get; set; }
        [JsonProperty("secureClubPresenceInfoString")]
        public string SecureClubPresenceInfoString { get; set; }
    }
}

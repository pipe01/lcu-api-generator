using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsClubMembershipDto
    {
        [JsonProperty("activeMembers")]
        public LolClubsMemberSinceDto[] ActiveMembers { get; set; }
        [JsonProperty("clubKey")]
        public string ClubKey { get; set; }
        [JsonProperty("invitedMembers")]
        public LolClubsMemberSinceDto[] InvitedMembers { get; set; }
        [JsonProperty("nominatedMembers")]
        public LolClubsMemberSinceDto[] NominatedMembers { get; set; }
        [JsonProperty("removedMembers")]
        public LolClubsMemberSinceDto[] RemovedMembers { get; set; }
    }
}

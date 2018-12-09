using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsClubMemberLists
    {
        [JsonProperty("activeMembers")]
        public LolClubsClubMember[] ActiveMembers { get; set; }
        [JsonProperty("invitedMembers")]
        public LolClubsClubMember[] InvitedMembers { get; set; }
        [JsonProperty("nominatedMembers")]
        public LolClubsClubMember[] NominatedMembers { get; set; }
        [JsonProperty("removedMembers")]
        public LolClubsClubMember[] RemovedMembers { get; set; }
    }
}

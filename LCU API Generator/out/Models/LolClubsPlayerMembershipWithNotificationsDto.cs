using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsPlayerMembershipWithNotificationsDto
    {
        [JsonProperty("membershipNotifications")]
        public LolClubsMembershipNoficationsDto[] MembershipNotifications { get; set; }
        [JsonProperty("playerMembership")]
        public LolClubsPlayerMembershipDto PlayerMembership { get; set; }
    }
}

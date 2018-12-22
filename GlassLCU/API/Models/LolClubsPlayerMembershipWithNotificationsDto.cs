using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

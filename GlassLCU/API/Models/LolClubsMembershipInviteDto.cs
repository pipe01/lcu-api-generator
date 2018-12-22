using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClubsMembershipInviteDto
    {
        [JsonProperty("clubKey")]
        public string ClubKey { get; set; }
        [JsonProperty("clubName")]
        public string ClubName { get; set; }
        [JsonProperty("inviteeAccountId")]
        public long InviteeAccountId { get; set; }
        [JsonProperty("inviteePlatformId")]
        public string InviteePlatformId { get; set; }
        [JsonProperty("inviteeSummonerId")]
        public long InviteeSummonerId { get; set; }
        [JsonProperty("inviterAccountId")]
        public long InviterAccountId { get; set; }
        [JsonProperty("inviterPlatformId")]
        public string InviterPlatformId { get; set; }
        [JsonProperty("inviterSummonerId")]
        public long InviterSummonerId { get; set; }
        [JsonProperty("status")]
        public int Status { get; set; }
    }
}

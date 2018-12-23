//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClubsClubInvite
    {
        [JsonProperty("clubKey")]
        public string ClubKey { get; set; }
        [JsonProperty("clubName")]
        public string ClubName { get; set; }
        [JsonProperty("inviteeAccountId")]
        public long InviteeAccountId { get; set; }
        [JsonProperty("inviteeSummonerId")]
        public long InviteeSummonerId { get; set; }
        [JsonProperty("inviterAccountId")]
        public long InviterAccountId { get; set; }
        [JsonProperty("inviterSummonerId")]
        public long InviterSummonerId { get; set; }
        [JsonProperty("inviterSummonerName")]
        public string InviterSummonerName { get; set; }
        [JsonProperty("status")]
        public LolClubsClubInviteStatus Status { get; set; }
    }
}

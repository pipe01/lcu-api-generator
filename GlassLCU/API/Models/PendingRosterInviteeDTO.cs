using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PendingRosterInviteeDTO
    {
        [JsonProperty("inviteTime")]
        public long InviteTime { get; set; }
        [JsonProperty("inviteeId")]
        public long InviteeId { get; set; }
        [JsonProperty("inviteeState")]
        public PendingRosterInviteeState InviteeState { get; set; }
        [JsonProperty("inviter")]
        public long Inviter { get; set; }
    }
}

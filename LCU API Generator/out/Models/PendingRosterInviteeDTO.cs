using Newtonsoft.Json;

namespace LCU_API_Generator
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

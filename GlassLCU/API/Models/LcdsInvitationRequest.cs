using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LcdsInvitationRequest
    {
        [JsonProperty("gameMetaData")]
        public string GameMetaData { get; set; }
        [JsonProperty("invitationId")]
        public string InvitationId { get; set; }
        [JsonProperty("invitationState")]
        public LcdsInvitationState InvitationState { get; set; }
        [JsonProperty("invitePayload")]
        public string InvitePayload { get; set; }
        [JsonProperty("inviteType")]
        public string InviteType { get; set; }
        [JsonProperty("inviter")]
        public LcdsInviter Inviter { get; set; }
        [JsonProperty("owner")]
        public LcdsPlayer Owner { get; set; }
    }
}

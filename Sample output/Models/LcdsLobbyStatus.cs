using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LcdsLobbyStatus
    {
        [JsonProperty("chatKey")]
        public string ChatKey { get; set; }
        [JsonProperty("gameMetaData")]
        public string GameMetaData { get; set; }
        [JsonProperty("invitationId")]
        public string InvitationId { get; set; }
        [JsonProperty("invitees")]
        public LcdsInvitee[] Invitees { get; set; }
        [JsonProperty("members")]
        public LcdsMember[] Members { get; set; }
        [JsonProperty("owner")]
        public LcdsPlayer Owner { get; set; }
    }
}

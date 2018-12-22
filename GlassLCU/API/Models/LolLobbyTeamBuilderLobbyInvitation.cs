using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderLobbyInvitation
    {
        [JsonProperty("invitationMetaData")]
        public object InvitationMetaData { get; set; }
    }
}

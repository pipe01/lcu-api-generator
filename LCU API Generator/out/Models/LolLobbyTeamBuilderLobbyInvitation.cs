using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderLobbyInvitation
    {
        [JsonProperty("invitationMetaData")]
        public object InvitationMetaData { get; set; }
    }
}

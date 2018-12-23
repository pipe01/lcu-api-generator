//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyLobbyDto
    {
        [JsonProperty("canStartActivity")]
        public bool CanStartActivity { get; set; }
        [JsonProperty("chatRoomId")]
        public string ChatRoomId { get; set; }
        [JsonProperty("chatRoomKey")]
        public string ChatRoomKey { get; set; }
        [JsonProperty("gameConfig")]
        public LolLobbyLobbyGameConfigDto GameConfig { get; set; }
        [JsonProperty("invitations")]
        public LolLobbyLobbyInvitationDto[] Invitations { get; set; }
        [JsonProperty("localMember")]
        public LolLobbyLobbyParticipantDto LocalMember { get; set; }
        [JsonProperty("members")]
        public LolLobbyLobbyParticipantDto[] Members { get; set; }
        [JsonProperty("partyId")]
        public string PartyId { get; set; }
        [JsonProperty("partyType")]
        public string PartyType { get; set; }
        [JsonProperty("restrictions")]
        public LolLobbyEligibilityRestriction[] Restrictions { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyReceivedInvitationDto
    {
        [JsonProperty("canAcceptInvitation")]
        public bool CanAcceptInvitation { get; set; }
        [JsonProperty("fromSummonerId")]
        public long FromSummonerId { get; set; }
        [JsonProperty("fromSummonerName")]
        public string FromSummonerName { get; set; }
        [JsonProperty("gameConfig")]
        public LolLobbyReceivedInvitationGameConfigDto GameConfig { get; set; }
        [JsonProperty("invitationId")]
        public string InvitationId { get; set; }
        [JsonProperty("restrictions")]
        public LolLobbyEligibilityRestriction[] Restrictions { get; set; }
        [JsonProperty("state")]
        public LolLobbyLobbyInvitationState State { get; set; }
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }
}
using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderLobby
    {
        [JsonProperty("allowablePremadeSizes")]
        public int[] AllowablePremadeSizes { get; set; }
        [JsonProperty("autoFillEligible")]
        public bool AutoFillEligible { get; set; }
        [JsonProperty("autoFillProtectedForPromos")]
        public bool AutoFillProtectedForPromos { get; set; }
        [JsonProperty("autoFillProtectedForStreaking")]
        public bool AutoFillProtectedForStreaking { get; set; }
        [JsonProperty("canStartMatchmaking")]
        public bool CanStartMatchmaking { get; set; }
        [JsonProperty("chatRoomId")]
        public string ChatRoomId { get; set; }
        [JsonProperty("chatRoomKey")]
        public string ChatRoomKey { get; set; }
        [JsonProperty("invitationId")]
        public string InvitationId { get; set; }
        [JsonProperty("invitations")]
        public LolLobbyTeamBuilderLobbyInvitation[] Invitations { get; set; }
        [JsonProperty("isTeamBuilderManaged")]
        public bool IsTeamBuilderManaged { get; set; }
        [JsonProperty("localMember")]
        public LolLobbyTeamBuilderLobbyMember LocalMember { get; set; }
        [JsonProperty("members")]
        public LolLobbyTeamBuilderLobbyMember[] Members { get; set; }
        [JsonProperty("premadeSizeAllowed")]
        public bool PremadeSizeAllowed { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("removalReason")]
        public LolLobbyTeamBuilderLobbyRemovedFromGameReason RemovalReason { get; set; }
        [JsonProperty("requiredPositionCoverageMet")]
        public bool RequiredPositionCoverageMet { get; set; }
        [JsonProperty("showPositionExcluder")]
        public bool ShowPositionExcluder { get; set; }
        [JsonProperty("showPositionSelector")]
        public bool ShowPositionSelector { get; set; }
        [JsonProperty("specifiablePositionPreferences")]
        public string[] SpecifiablePositionPreferences { get; set; }
        [JsonProperty("wasKicked")]
        public bool WasKicked { get; set; }
    }
}

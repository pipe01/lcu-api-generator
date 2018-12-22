using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyLobby
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
        [JsonProperty("customGameLobby")]
        public LolLobbyLobbyCustomGameLobby CustomGameLobby { get; set; }
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("invitationId")]
        public string InvitationId { get; set; }
        [JsonProperty("invitations")]
        public LolLobbyLobbyInvitation[] Invitations { get; set; }
        [JsonProperty("isCustom")]
        public bool IsCustom { get; set; }
        [JsonProperty("isTeamBuilderManaged")]
        public bool IsTeamBuilderManaged { get; set; }
        [JsonProperty("localMember")]
        public LolLobbyLobbyMember LocalMember { get; set; }
        [JsonProperty("mapId")]
        public int MapId { get; set; }
        [JsonProperty("maximumParticipantListSize")]
        public int MaximumParticipantListSize { get; set; }
        [JsonProperty("members")]
        public LolLobbyLobbyMember[] Members { get; set; }
        [JsonProperty("premadeSizeAllowed")]
        public bool PremadeSizeAllowed { get; set; }
        [JsonProperty("queueAvailability")]
        public LolLobbyQueueAvailability QueueAvailability { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("removalReason")]
        public LolLobbyLobbyRemovedFromGameReason RemovalReason { get; set; }
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

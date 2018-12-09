using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderTbLobbyPremadeStateResource
    {
        [JsonProperty("autoFillEligible")]
        public bool AutoFillEligible { get; set; }
        [JsonProperty("autoFillProtectedForPromos")]
        public bool AutoFillProtectedForPromos { get; set; }
        [JsonProperty("autoFillProtectedForStreaking")]
        public bool AutoFillProtectedForStreaking { get; set; }
        [JsonProperty("backwardsToPremadeTransitionReason")]
        public LolLobbyTeamBuilderTbLobbyBackwardsToPremadeTransitionResource BackwardsToPremadeTransitionReason { get; set; }
        [JsonProperty("captainSlotId")]
        public int CaptainSlotId { get; set; }
        [JsonProperty("draftPremadeId")]
        public string DraftPremadeId { get; set; }
        [JsonProperty("draftSlots")]
        public LolLobbyTeamBuilderTbLobbySlotResource[] DraftSlots { get; set; }
        [JsonProperty("localPlayerSlotId")]
        public int LocalPlayerSlotId { get; set; }
        [JsonProperty("playableDraftPositions")]
        public string[] PlayableDraftPositions { get; set; }
        [JsonProperty("premadeChatRoomId")]
        public string PremadeChatRoomId { get; set; }
        [JsonProperty("readyState")]
        public LolLobbyTeamBuilderReadyStateV1 ReadyState { get; set; }
        [JsonProperty("readyToMatchmake")]
        public bool ReadyToMatchmake { get; set; }
        [JsonProperty("showPositionExcluder")]
        public bool ShowPositionExcluder { get; set; }
        [JsonProperty("showPositionSelector")]
        public bool ShowPositionSelector { get; set; }
        [JsonProperty("timer")]
        public long Timer { get; set; }
    }
}

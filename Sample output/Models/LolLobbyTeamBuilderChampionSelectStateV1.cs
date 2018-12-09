using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderChampionSelectStateV1
    {
        [JsonProperty("actionSetList")]
        public object[] ActionSetList { get; set; }
        [JsonProperty("allowDuplicatePicks")]
        public bool AllowDuplicatePicks { get; set; }
        [JsonProperty("allowOptingOutOfBanning")]
        public bool AllowOptingOutOfBanning { get; set; }
        [JsonProperty("allowSkinSelection")]
        public bool AllowSkinSelection { get; set; }
        [JsonProperty("battleBoostState")]
        public LolLobbyTeamBuilderTeamBuilderBoostInfo BattleBoostState { get; set; }
        [JsonProperty("cells")]
        public LolLobbyTeamBuilderCellsV1 Cells { get; set; }
        [JsonProperty("ceremoniesByActionSetIndex")]
        public object CeremoniesByActionSetIndex { get; set; }
        [JsonProperty("championBenchState")]
        public LolLobbyTeamBuilderChampionBenchStateV1 ChampionBenchState { get; set; }
        [JsonProperty("currentActionSetIndex")]
        public int CurrentActionSetIndex { get; set; }
        [JsonProperty("currentTimeRemainingMillis")]
        public long CurrentTimeRemainingMillis { get; set; }
        [JsonProperty("currentTotalTimeMillis")]
        public long CurrentTotalTimeMillis { get; set; }
        [JsonProperty("inventoryDraft")]
        public LolLobbyTeamBuilderTbdInventory InventoryDraft { get; set; }
        [JsonProperty("lcuSkipsSendingLoadoutsGco")]
        public bool LcuSkipsSendingLoadoutsGco { get; set; }
        [JsonProperty("localPlayerCellId")]
        public int LocalPlayerCellId { get; set; }
        [JsonProperty("lockedEventsState")]
        public LolLobbyTeamBuilderLockedEventsStateV1 LockedEventsState { get; set; }
        [JsonProperty("pickIntentClearedReason")]
        public string PickIntentClearedReason { get; set; }
        [JsonProperty("rerollState")]
        public LolLobbyTeamBuilderRerollStateV1 RerollState { get; set; }
        [JsonProperty("subphase")]
        public string Subphase { get; set; }
        [JsonProperty("teamChatRoomId")]
        public string TeamChatRoomId { get; set; }
        [JsonProperty("teamId")]
        public string TeamId { get; set; }
        [JsonProperty("trades")]
        public LolLobbyTeamBuilderTradeV1[] Trades { get; set; }
    }
}

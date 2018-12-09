using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderChampSelectSession
    {
        [JsonProperty("actions")]
        public object[] Actions { get; set; }
        [JsonProperty("allowBattleBoost")]
        public bool AllowBattleBoost { get; set; }
        [JsonProperty("allowDuplicatePicks")]
        public bool AllowDuplicatePicks { get; set; }
        [JsonProperty("allowLockedEvents")]
        public bool AllowLockedEvents { get; set; }
        [JsonProperty("allowRerolling")]
        public bool AllowRerolling { get; set; }
        [JsonProperty("allowSkinSelection")]
        public bool AllowSkinSelection { get; set; }
        [JsonProperty("benchChampionIds")]
        public int[] BenchChampionIds { get; set; }
        [JsonProperty("benchEnabled")]
        public bool BenchEnabled { get; set; }
        [JsonProperty("boostableSkinCount")]
        public int BoostableSkinCount { get; set; }
        [JsonProperty("chatDetails")]
        public LolLobbyTeamBuilderChampSelectChatRoomDetails ChatDetails { get; set; }
        [JsonProperty("counter")]
        public long Counter { get; set; }
        [JsonProperty("localPlayerCellId")]
        public long LocalPlayerCellId { get; set; }
        [JsonProperty("lockedEventIndex")]
        public int LockedEventIndex { get; set; }
        [JsonProperty("myTeam")]
        public LolLobbyTeamBuilderChampSelectPlayerSelection[] MyTeam { get; set; }
        [JsonProperty("rerollsRemaining")]
        public int RerollsRemaining { get; set; }
        [JsonProperty("theirTeam")]
        public LolLobbyTeamBuilderChampSelectPlayerSelection[] TheirTeam { get; set; }
        [JsonProperty("timer")]
        public LolLobbyTeamBuilderChampSelectTimer Timer { get; set; }
        [JsonProperty("trades")]
        public LolLobbyTeamBuilderChampSelectTradeContract[] Trades { get; set; }
    }
}

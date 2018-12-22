using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampSelectChampSelectSession
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
        [JsonProperty("bans")]
        public LolChampSelectChampSelectBannedChampions Bans { get; set; }
        [JsonProperty("benchChampionIds")]
        public int[] BenchChampionIds { get; set; }
        [JsonProperty("benchEnabled")]
        public bool BenchEnabled { get; set; }
        [JsonProperty("boostableSkinCount")]
        public int BoostableSkinCount { get; set; }
        [JsonProperty("chatDetails")]
        public LolChampSelectChampSelectChatRoomDetails ChatDetails { get; set; }
        [JsonProperty("counter")]
        public long Counter { get; set; }
        [JsonProperty("isSpectating")]
        public bool IsSpectating { get; set; }
        [JsonProperty("localPlayerCellId")]
        public long LocalPlayerCellId { get; set; }
        [JsonProperty("lockedEventIndex")]
        public int LockedEventIndex { get; set; }
        [JsonProperty("myTeam")]
        public LolChampSelectChampSelectPlayerSelection[] MyTeam { get; set; }
        [JsonProperty("rerollsRemaining")]
        public int RerollsRemaining { get; set; }
        [JsonProperty("theirTeam")]
        public LolChampSelectChampSelectPlayerSelection[] TheirTeam { get; set; }
        [JsonProperty("timer")]
        public LolChampSelectChampSelectTimer Timer { get; set; }
        [JsonProperty("trades")]
        public LolChampSelectChampSelectTradeContract[] Trades { get; set; }
    }
}

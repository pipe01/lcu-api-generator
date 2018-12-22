using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampSelectLegacyChampSelectSession
    {
        [JsonProperty("actions")]
        public object[] Actions { get; set; }
        [JsonProperty("allowBattleBoost")]
        public bool AllowBattleBoost { get; set; }
        [JsonProperty("allowRerolling")]
        public bool AllowRerolling { get; set; }
        [JsonProperty("allowSkinSelection")]
        public bool AllowSkinSelection { get; set; }
        [JsonProperty("bans")]
        public LolChampSelectLegacyChampSelectBannedChampions Bans { get; set; }
        [JsonProperty("chatDetails")]
        public LolChampSelectLegacyChampSelectChatRoomDetails ChatDetails { get; set; }
        [JsonProperty("isSpectating")]
        public bool IsSpectating { get; set; }
        [JsonProperty("localPlayerCellId")]
        public long LocalPlayerCellId { get; set; }
        [JsonProperty("myTeam")]
        public LolChampSelectLegacyChampSelectPlayerSelection[] MyTeam { get; set; }
        [JsonProperty("rerollsRemaining")]
        public int RerollsRemaining { get; set; }
        [JsonProperty("theirTeam")]
        public LolChampSelectLegacyChampSelectPlayerSelection[] TheirTeam { get; set; }
        [JsonProperty("timer")]
        public LolChampSelectLegacyChampSelectTimer Timer { get; set; }
        [JsonProperty("trades")]
        public LolChampSelectLegacyChampSelectTradeContract[] Trades { get; set; }
    }
}

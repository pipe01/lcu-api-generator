using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPerksChampSelectSession
    {
        [JsonProperty("actions")]
        public object[] Actions { get; set; }
        [JsonProperty("bans")]
        public LolPerksChampSelectBannedChampions Bans { get; set; }
        [JsonProperty("chatDetails")]
        public LolPerksChampSelectChatRoomDetails ChatDetails { get; set; }
        [JsonProperty("isSpectating")]
        public bool IsSpectating { get; set; }
        [JsonProperty("localPlayerCellId")]
        public long LocalPlayerCellId { get; set; }
        [JsonProperty("myTeam")]
        public LolPerksChampSelectPlayerSelection[] MyTeam { get; set; }
        [JsonProperty("theirTeam")]
        public LolPerksChampSelectPlayerSelection[] TheirTeam { get; set; }
        [JsonProperty("timer")]
        public LolPerksChampSelectTimer Timer { get; set; }
        [JsonProperty("trades")]
        public LolPerksChampSelectTradeContract[] Trades { get; set; }
    }
}

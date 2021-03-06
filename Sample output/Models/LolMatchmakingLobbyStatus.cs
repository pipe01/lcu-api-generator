//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMatchmakingLobbyStatus
    {
        [JsonProperty("allowedPlayAgain")]
        public bool AllowedPlayAgain { get; set; }
        [JsonProperty("customSpectatorPolicy")]
        public LolMatchmakingQueueCustomGameSpectatorPolicy CustomSpectatorPolicy { get; set; }
        [JsonProperty("isCustom")]
        public bool IsCustom { get; set; }
        [JsonProperty("isLeader")]
        public bool IsLeader { get; set; }
        [JsonProperty("isSpectator")]
        public bool IsSpectator { get; set; }
        [JsonProperty("lobbyId")]
        public string LobbyId { get; set; }
        [JsonProperty("memberSummonerIds")]
        public long[] MemberSummonerIds { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
    }
}

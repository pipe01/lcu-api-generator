using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyLobbyStatus
    {
        [JsonProperty("allowedPlayAgain")]
        public bool AllowedPlayAgain { get; set; }
        [JsonProperty("customSpectatorPolicy")]
        public LolLobbyQueueCustomGameSpectatorPolicy CustomSpectatorPolicy { get; set; }
        [JsonProperty("invitedSummonerIds")]
        public long[] InvitedSummonerIds { get; set; }
        [JsonProperty("isCustom")]
        public bool IsCustom { get; set; }
        [JsonProperty("isLeader")]
        public bool IsLeader { get; set; }
        [JsonProperty("isPracticeTool")]
        public bool IsPracticeTool { get; set; }
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

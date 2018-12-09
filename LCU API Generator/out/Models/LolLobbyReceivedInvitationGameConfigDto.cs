using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyReceivedInvitationGameConfigDto
    {
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("inviteGameType")]
        public string InviteGameType { get; set; }
        [JsonProperty("mapId")]
        public int MapId { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
    }
}

//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

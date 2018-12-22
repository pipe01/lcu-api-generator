using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyLobbyInvitationDto
    {
        [JsonProperty("invitationId")]
        public string InvitationId { get; set; }
        [JsonProperty("state")]
        public LolLobbyLobbyInvitationState State { get; set; }
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
        [JsonProperty("toSummonerId")]
        public long ToSummonerId { get; set; }
        [JsonProperty("toSummonerName")]
        public string ToSummonerName { get; set; }
    }
}

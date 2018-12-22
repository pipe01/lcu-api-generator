using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChatLobbyMember
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("isOwner")]
        public bool IsOwner { get; set; }
    }
}
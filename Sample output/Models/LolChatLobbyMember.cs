using Newtonsoft.Json;

namespace LCU_API_Generator
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

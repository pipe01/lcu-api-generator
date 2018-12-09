using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatConversationResource
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("inviterId")]
        public string InviterId { get; set; }
        [JsonProperty("isMuted")]
        public bool IsMuted { get; set; }
        [JsonProperty("lastMessage")]
        public LolChatConversationMessageResource LastMessage { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("unreadMessageCount")]
        public long UnreadMessageCount { get; set; }
    }
}

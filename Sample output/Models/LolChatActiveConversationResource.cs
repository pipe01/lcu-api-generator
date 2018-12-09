using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatActiveConversationResource
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

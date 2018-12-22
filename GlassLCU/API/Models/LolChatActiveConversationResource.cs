using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChatActiveConversationResource
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChatConversationMessageResource
    {
        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("fromId")]
        public long FromId { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("isHistorical")]
        public bool IsHistorical { get; set; }
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

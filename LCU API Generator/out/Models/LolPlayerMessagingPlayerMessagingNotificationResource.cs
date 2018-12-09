using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPlayerMessagingPlayerMessagingNotificationResource
    {
        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("msgId")]
        public string MsgId { get; set; }
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}

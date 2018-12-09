using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatErrorResource
    {
        [JsonProperty("code")]
        public long Code { get; set; }
        [JsonProperty("from")]
        public string From { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}

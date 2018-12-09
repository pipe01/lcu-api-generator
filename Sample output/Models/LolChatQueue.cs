using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatQueue
    {
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("gameTypeConfig")]
        public LolChatQueueGameTypeConfig GameTypeConfig { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

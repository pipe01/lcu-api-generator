using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatFriendRequestResource
    {
        [JsonProperty("direction")]
        public LolChatFriendRequestDirection Direction { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("note")]
        public string Note { get; set; }
    }
}

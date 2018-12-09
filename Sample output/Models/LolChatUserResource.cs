using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatUserResource
    {
        [JsonProperty("availability")]
        public string Availability { get; set; }
        [JsonProperty("icon")]
        public int Icon { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("lastSeenOnlineTimestamp")]
        public string LastSeenOnlineTimestamp { get; set; }
        [JsonProperty("lol")]
        public object Lol { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("statusMessage")]
        public string StatusMessage { get; set; }
    }
}

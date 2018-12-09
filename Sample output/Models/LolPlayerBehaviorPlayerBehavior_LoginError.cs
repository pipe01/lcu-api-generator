using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPlayerBehaviorPlayerBehavior_LoginError
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("messageId")]
        public string MessageId { get; set; }
    }
}

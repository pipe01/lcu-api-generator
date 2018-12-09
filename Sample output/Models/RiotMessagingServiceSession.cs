using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RiotMessagingServiceSession
    {
        [JsonProperty("state")]
        public RiotMessagingServiceState State { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("tokenType")]
        public RiotMessagingServiceTokenType TokenType { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
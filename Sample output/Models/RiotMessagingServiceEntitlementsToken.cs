using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RiotMessagingServiceEntitlementsToken
    {
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
        [JsonProperty("entitlements")]
        public string[] Entitlements { get; set; }
        [JsonProperty("issuer")]
        public string Issuer { get; set; }
        [JsonProperty("subject")]
        public string Subject { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}

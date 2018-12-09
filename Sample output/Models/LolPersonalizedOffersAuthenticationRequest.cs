using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPersonalizedOffersAuthenticationRequest
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("tokenType")]
        public string TokenType { get; set; }
    }
}

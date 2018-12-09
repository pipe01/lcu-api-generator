using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPersonalizedOffersAuthenticationResponse
    {
        [JsonProperty("expiration")]
        public string Expiration { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}

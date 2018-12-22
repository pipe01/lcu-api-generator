using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

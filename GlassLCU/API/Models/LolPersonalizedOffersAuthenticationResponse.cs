using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

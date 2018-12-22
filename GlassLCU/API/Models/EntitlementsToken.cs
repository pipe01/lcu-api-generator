using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class EntitlementsToken
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

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RsoAuthEntitlementsToken
    {
        [JsonProperty("entitlements")]
        public string[] Entitlements { get; set; }
        [JsonProperty("expiry")]
        public long Expiry { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}

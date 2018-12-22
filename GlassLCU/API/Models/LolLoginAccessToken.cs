using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLoginAccessToken
    {
        [JsonProperty("expiry")]
        public long Expiry { get; set; }
        [JsonProperty("scopes")]
        public string[] Scopes { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}

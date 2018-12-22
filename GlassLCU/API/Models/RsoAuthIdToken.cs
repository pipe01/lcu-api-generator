using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RsoAuthIdToken
    {
        [JsonProperty("expiry")]
        public long Expiry { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}

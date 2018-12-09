using Newtonsoft.Json;

namespace LCU_API_Generator
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

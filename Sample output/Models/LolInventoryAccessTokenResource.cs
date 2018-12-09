using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolInventoryAccessTokenResource
    {
        [JsonProperty("expiry")]
        public long Expiry { get; set; }
        [JsonProperty("scopes")]
        public string[] Scopes { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}

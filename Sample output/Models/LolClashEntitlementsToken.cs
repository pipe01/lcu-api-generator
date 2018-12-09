using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashEntitlementsToken
    {
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
        [JsonProperty("entitlements")]
        public string[] Entitlements { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RsoAuthPublicClientConfig
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

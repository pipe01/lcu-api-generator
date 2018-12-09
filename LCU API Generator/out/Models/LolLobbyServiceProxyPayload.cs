using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyServiceProxyPayload
    {
        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("method")]
        public string Method { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

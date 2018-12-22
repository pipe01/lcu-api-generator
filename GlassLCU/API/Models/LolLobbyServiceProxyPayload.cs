using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

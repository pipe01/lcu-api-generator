using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LcdsPayloadDto
    {
        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("headers")]
        public object Headers { get; set; }
        [JsonProperty("method")]
        public string Method { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
    }
}

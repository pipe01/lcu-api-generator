using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLoginLcdsServiceProxyResponse
    {
        [JsonProperty("compressedPayload")]
        public bool CompressedPayload { get; set; }
        [JsonProperty("messageId")]
        public string MessageId { get; set; }
        [JsonProperty("methodName")]
        public string MethodName { get; set; }
        [JsonProperty("payload")]
        public string Payload { get; set; }
        [JsonProperty("serviceName")]
        public string ServiceName { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

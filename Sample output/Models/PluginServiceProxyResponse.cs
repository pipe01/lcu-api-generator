using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PluginServiceProxyResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }
        [JsonProperty("methodName")]
        public string MethodName { get; set; }
        [JsonProperty("payload")]
        public string Payload { get; set; }
        [JsonProperty("serviceName")]
        public string ServiceName { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }
}

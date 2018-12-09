using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RecofrienderDebugConfig
    {
        [JsonProperty("isHttpLoggingEnabled")]
        public bool IsHttpLoggingEnabled { get; set; }
    }
}

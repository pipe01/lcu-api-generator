using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RecofrienderDebugConfig
    {
        [JsonProperty("isHttpLoggingEnabled")]
        public bool IsHttpLoggingEnabled { get; set; }
    }
}

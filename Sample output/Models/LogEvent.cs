using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LogEvent
    {
        [JsonProperty("message")]
        public string Message { get; set; }
        /// <summary>
        /// Allowable severity levels for log events.
        /// </summary>
        [JsonProperty("severity")]
        public LogSeverityLevels Severity { get; set; }
    }
}

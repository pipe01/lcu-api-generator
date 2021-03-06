//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

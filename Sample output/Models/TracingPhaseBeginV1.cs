//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class TracingPhaseBeginV1
    {
        [JsonProperty("importance")]
        public TracingPhaseImportanceV1 Importance { get; set; }
        /// <summary>
        /// phase name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// timestamp in microseconds of when the phase began
        /// </summary>
        [JsonProperty("when")]
        public long When { get; set; }
    }
}

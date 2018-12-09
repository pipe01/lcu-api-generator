using Newtonsoft.Json;

namespace LCU_API_Generator
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

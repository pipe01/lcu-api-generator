using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class TracingPhaseEndV1
    {
        /// <summary>
        /// phase name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// timestamp in microseconds of when the phase ended
        /// </summary>
        [JsonProperty("when")]
        public long When { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class TracingEventV1
    {
        /// <summary>
        /// destination module name
        /// </summary>
        [JsonProperty("dest")]
        public string Dest { get; set; }
        /// <summary>
        /// event specific details
        /// </summary>
        [JsonProperty("details")]
        public string Details { get; set; }
        /// <summary>
        /// event name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// source module name
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }
        /// <summary>
        /// a list of tags associated with this event
        /// </summary>
        [JsonProperty("tags")]
        public string Tags { get; set; }
        /// <summary>
        /// timestamp in microseconds of when the event occurred
        /// </summary>
        [JsonProperty("when")]
        public long When { get; set; }
    }
}

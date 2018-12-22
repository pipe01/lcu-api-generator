using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class basicSystemInfo
    {
        /// <summary>
        /// User Experience Settings Operating System Information
        /// </summary>
        [JsonProperty("operatingSystem")]
        public basicOperatingSystemInfo OperatingSystem { get; set; }
        [JsonProperty("physicalMemory")]
        public long PhysicalMemory { get; set; }
        [JsonProperty("physicalProcessorCores")]
        public int PhysicalProcessorCores { get; set; }
        [JsonProperty("processorSpeed")]
        public int ProcessorSpeed { get; set; }
    }
}

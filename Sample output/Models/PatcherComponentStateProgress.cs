using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PatcherComponentStateProgress
    {
        [JsonProperty("bytesComplete")]
        public long BytesComplete { get; set; }
        [JsonProperty("bytesPerSecond")]
        public float BytesPerSecond { get; set; }
        [JsonProperty("bytesRequired")]
        public long BytesRequired { get; set; }
    }
}

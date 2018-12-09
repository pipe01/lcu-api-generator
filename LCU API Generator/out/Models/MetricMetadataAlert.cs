using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class MetricMetadataAlert
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("info")]
        public string Info { get; set; }
        [JsonProperty("level")]
        public string Level { get; set; }
        [JsonProperty("max")]
        public float Max { get; set; }
        [JsonProperty("min")]
        public float Min { get; set; }
        [JsonProperty("notify")]
        public MetricMetadataNotify Notify { get; set; }
        [JsonProperty("pretty_name")]
        public string Pretty_name { get; set; }
    }
}

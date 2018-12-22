using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class MetricMetadata
    {
        [JsonProperty("alerts")]
        public MetricMetadataAlert[] Alerts { get; set; }
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("data_type")]
        public MetricDataType Data_type { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("destination")]
        public string Destination { get; set; }
        [JsonProperty("info")]
        public string Info { get; set; }
        [JsonProperty("notify")]
        public MetricMetadataNotify Notify { get; set; }
        [JsonProperty("period")]
        public int Period { get; set; }
        [JsonProperty("pretty_name")]
        public string Pretty_name { get; set; }
        [JsonProperty("priority")]
        public MetricPriority Priority { get; set; }
        [JsonProperty("sample_window_ms")]
        public int Sample_window_ms { get; set; }
        [JsonProperty("transientAggregation")]
        public AggregationType TransientAggregation { get; set; }
        [JsonProperty("type")]
        public MetricType Type { get; set; }
        [JsonProperty("units")]
        public string Units { get; set; }
    }
}

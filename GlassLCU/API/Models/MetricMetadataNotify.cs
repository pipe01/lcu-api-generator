using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class MetricMetadataNotify
    {
        [JsonProperty("email")]
        public string[] Email { get; set; }
        [JsonProperty("hipchat")]
        public MetricMetadataHipchatNotification[] Hipchat { get; set; }
        [JsonProperty("pagerduty")]
        public MetricMetadataPagerDutyNotification[] Pagerduty { get; set; }
    }
}

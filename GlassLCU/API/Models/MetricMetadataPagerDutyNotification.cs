using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class MetricMetadataPagerDutyNotification
    {
        [JsonProperty("apikey")]
        public string Apikey { get; set; }
    }
}

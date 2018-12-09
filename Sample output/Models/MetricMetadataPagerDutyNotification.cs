using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class MetricMetadataPagerDutyNotification
    {
        [JsonProperty("apikey")]
        public string Apikey { get; set; }
    }
}

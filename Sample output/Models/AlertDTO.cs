using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class AlertDTO
    {
        [JsonProperty("alertTime")]
        public long AlertTime { get; set; }
    }
}

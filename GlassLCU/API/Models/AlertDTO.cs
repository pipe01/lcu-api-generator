using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class AlertDTO
    {
        [JsonProperty("alertTime")]
        public long AlertTime { get; set; }
    }
}

//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class MissionAlertDTO
    {
        [JsonProperty("alertTime")]
        public long AlertTime { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

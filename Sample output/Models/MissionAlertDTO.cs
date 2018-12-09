using Newtonsoft.Json;

namespace LCU_API_Generator
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

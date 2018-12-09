using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolTencentQtTencentQTNotification
    {
        [JsonProperty("data")]
        public object Data { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }
    }
}

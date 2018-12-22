using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolStoreOrderNotificationResource
    {
        [JsonProperty("eventType")]
        public string EventType { get; set; }
        [JsonProperty("eventTypeId")]
        public string EventTypeId { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyLobbyNotification
    {
        [JsonProperty("notificationId")]
        public string NotificationId { get; set; }
        [JsonProperty("notificationReason")]
        public string NotificationReason { get; set; }
        [JsonProperty("summonerIds")]
        public long[] SummonerIds { get; set; }
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}

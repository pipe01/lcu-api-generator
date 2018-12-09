using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLeaverBusterLeaverBusterNotificationResource
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("msgId")]
        public string MsgId { get; set; }
        [JsonProperty("punishedGamesRemaining")]
        public int PunishedGamesRemaining { get; set; }
        [JsonProperty("type")]
        public LolLeaverBusterLeaverBusterNotificationType Type { get; set; }
    }
}

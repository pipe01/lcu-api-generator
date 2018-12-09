using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashRosterPlayerNotification
    {
        [JsonProperty("notifyReason")]
        public LolClashRosterNotifyReason NotifyReason { get; set; }
        [JsonProperty("playerNotificationDTO")]
        public PlayerDTO PlayerNotificationDTO { get; set; }
        [JsonProperty("roster")]
        public RosterDTO Roster { get; set; }
        [JsonProperty("sourcePlayerId")]
        public long SourcePlayerId { get; set; }
    }
}

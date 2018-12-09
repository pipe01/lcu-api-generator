using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashPendingRosterNotification
    {
        [JsonProperty("notifyReason")]
        public LolClashNotifyReason NotifyReason { get; set; }
        [JsonProperty("pendingRoster")]
        public PendingRosterDTO PendingRoster { get; set; }
        [JsonProperty("sourcePlayerId")]
        public long SourcePlayerId { get; set; }
        [JsonProperty("targetPlayerId")]
        public long TargetPlayerId { get; set; }
    }
}

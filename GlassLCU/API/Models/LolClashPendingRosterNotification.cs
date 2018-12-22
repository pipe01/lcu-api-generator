using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

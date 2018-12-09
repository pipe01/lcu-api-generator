using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashRosterDynamicStateNotification
    {
        [JsonProperty("notifyReason")]
        public LolClashRosterNotifyReason NotifyReason { get; set; }
        [JsonProperty("rosterDynamicState")]
        public RosterDynamicStateDTO RosterDynamicState { get; set; }
        [JsonProperty("sourcePlayerId")]
        public long SourcePlayerId { get; set; }
    }
}

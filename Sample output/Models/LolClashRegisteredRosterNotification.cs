using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashRegisteredRosterNotification
    {
        [JsonProperty("notifyReason")]
        public LolClashRosterNotifyReason NotifyReason { get; set; }
        [JsonProperty("roster")]
        public RosterDTO Roster { get; set; }
    }
}

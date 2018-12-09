using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashPlayerNotificationData
    {
        [JsonProperty("keySuffix")]
        public string KeySuffix { get; set; }
        [JsonProperty("notification")]
        public LolClashPlayerNotification Notification { get; set; }
        [JsonProperty("notifyReason")]
        public LolClashNotifyReason NotifyReason { get; set; }
        [JsonProperty("rosterNotifyReason")]
        public LolClashRosterNotifyReason RosterNotifyReason { get; set; }
        [JsonProperty("sourceSummonerId")]
        public long SourceSummonerId { get; set; }
        [JsonProperty("targetSummonerId")]
        public long TargetSummonerId { get; set; }
        [JsonProperty("tournamentNotifyReason")]
        public LolClashTournamentNotifyReason TournamentNotifyReason { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRankedLeaguesNotification
    {
        [JsonProperty("acknowledgedByPlayer")]
        public bool AcknowledgedByPlayer { get; set; }
        [JsonProperty("data")]
        public LolRankedLeagueNotificationItem Data { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("priority")]
        public long Priority { get; set; }
        [JsonProperty("relatedData")]
        public object RelatedData { get; set; }
        [JsonProperty("severity")]
        public LolRankedSeverity Severity { get; set; }
        [JsonProperty("titleType")]
        public string TitleType { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

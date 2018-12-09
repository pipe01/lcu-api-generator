using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyPartiesInvitationAnalytics
    {
        [JsonProperty("eventData")]
        public object EventData { get; set; }
        [JsonProperty("eventTimestamp")]
        public long EventTimestamp { get; set; }
        [JsonProperty("eventType")]
        public string EventType { get; set; }
        [JsonProperty("partyId")]
        public string PartyId { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
        [JsonProperty("players")]
        public LolLobbyPartiesInvitationPlayerAnalytics[] Players { get; set; }
    }
}

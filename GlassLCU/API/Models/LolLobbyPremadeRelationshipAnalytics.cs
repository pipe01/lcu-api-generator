using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyPremadeRelationshipAnalytics
    {
        [JsonProperty("eventData")]
        public object EventData { get; set; }
        [JsonProperty("eventTimestamp")]
        public long EventTimestamp { get; set; }
        [JsonProperty("eventType")]
        public string EventType { get; set; }
        [JsonProperty("friendPlayers")]
        public string[] FriendPlayers { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
        [JsonProperty("premadePlayers")]
        public string[] PremadePlayers { get; set; }
        [JsonProperty("puuid")]
        public string Puuid { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

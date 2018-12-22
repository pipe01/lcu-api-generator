using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyJoinPartyAnalytics
    {
        [JsonProperty("eventData")]
        public object EventData { get; set; }
        [JsonProperty("eventTimestamp")]
        public long EventTimestamp { get; set; }
        [JsonProperty("eventType")]
        public string EventType { get; set; }
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("numFriendsOnline")]
        public int NumFriendsOnline { get; set; }
        [JsonProperty("numOpenFriends")]
        public int NumOpenFriends { get; set; }
        [JsonProperty("numOpenParties")]
        public int NumOpenParties { get; set; }
        [JsonProperty("numOtherInvites")]
        public int NumOtherInvites { get; set; }
        [JsonProperty("numPartyInvites")]
        public int NumPartyInvites { get; set; }
        [JsonProperty("numTotalInvites")]
        public int NumTotalInvites { get; set; }
        [JsonProperty("partyId")]
        public string PartyId { get; set; }
        [JsonProperty("partySize")]
        public int PartySize { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
    }
}
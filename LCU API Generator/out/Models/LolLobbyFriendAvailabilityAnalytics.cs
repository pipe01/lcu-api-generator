using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyFriendAvailabilityAnalytics
    {
        [JsonProperty("eventData")]
        public object EventData { get; set; }
        [JsonProperty("eventTimestamp")]
        public long EventTimestamp { get; set; }
        [JsonProperty("eventType")]
        public string EventType { get; set; }
        [JsonProperty("numFriends")]
        public int NumFriends { get; set; }
        [JsonProperty("numFriendsAvailable")]
        public int NumFriendsAvailable { get; set; }
        [JsonProperty("numFriendsAway")]
        public int NumFriendsAway { get; set; }
        [JsonProperty("numFriendsInChampSelect")]
        public int NumFriendsInChampSelect { get; set; }
        [JsonProperty("numFriendsInGame")]
        public int NumFriendsInGame { get; set; }
        [JsonProperty("numFriendsInQueue")]
        public int NumFriendsInQueue { get; set; }
        [JsonProperty("numFriendsMobile")]
        public int NumFriendsMobile { get; set; }
        [JsonProperty("numFriendsOnline")]
        public int NumFriendsOnline { get; set; }
        [JsonProperty("partyType")]
        public string PartyType { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
        [JsonProperty("puuid")]
        public string Puuid { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

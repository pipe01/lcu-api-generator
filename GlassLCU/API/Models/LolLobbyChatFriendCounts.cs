using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyChatFriendCounts
    {
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
    }
}

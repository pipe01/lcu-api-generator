using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolStoreGiftingFriend
    {
        [JsonProperty("friendsSince")]
        public string FriendsSince { get; set; }
        [JsonProperty("nick")]
        public string Nick { get; set; }
        [JsonProperty("oldFriends")]
        public bool OldFriends { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

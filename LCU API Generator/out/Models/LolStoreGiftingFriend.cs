using Newtonsoft.Json;

namespace LCU_API_Generator
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

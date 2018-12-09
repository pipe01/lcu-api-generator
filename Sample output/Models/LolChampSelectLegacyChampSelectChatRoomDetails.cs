using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampSelectLegacyChampSelectChatRoomDetails
    {
        [JsonProperty("chatRoomName")]
        public string ChatRoomName { get; set; }
        [JsonProperty("chatRoomPassword")]
        public string ChatRoomPassword { get; set; }
    }
}

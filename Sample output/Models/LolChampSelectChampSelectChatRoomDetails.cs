using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampSelectChampSelectChatRoomDetails
    {
        [JsonProperty("chatRoomName")]
        public string ChatRoomName { get; set; }
        [JsonProperty("chatRoomPassword")]
        public string ChatRoomPassword { get; set; }
    }
}

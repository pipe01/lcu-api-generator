using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

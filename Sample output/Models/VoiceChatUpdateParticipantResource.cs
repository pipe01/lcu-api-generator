using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class VoiceChatUpdateParticipantResource
    {
        [JsonProperty("isMuted")]
        public bool IsMuted { get; set; }
        [JsonProperty("volume")]
        public int Volume { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class VoiceChatSessionResource
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("isMuted")]
        public bool IsMuted { get; set; }
        [JsonProperty("isTransmitEnabled")]
        public bool IsTransmitEnabled { get; set; }
        [JsonProperty("participants")]
        public VoiceChatParticipantResource[] Participants { get; set; }
        [JsonProperty("status")]
        public VoiceChatSessionStatus Status { get; set; }
        [JsonProperty("volume")]
        public int Volume { get; set; }
    }
}

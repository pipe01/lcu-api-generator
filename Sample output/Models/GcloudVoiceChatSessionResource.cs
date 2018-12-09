using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class GcloudVoiceChatSessionResource
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("isMuted")]
        public bool IsMuted { get; set; }
        [JsonProperty("isTransmitEnabled")]
        public bool IsTransmitEnabled { get; set; }
        [JsonProperty("participants")]
        public GcloudVoiceChatParticipantResource[] Participants { get; set; }
        [JsonProperty("status")]
        public GcloudVoiceChatSessionStatus Status { get; set; }
        [JsonProperty("volume")]
        public int Volume { get; set; }
    }
}

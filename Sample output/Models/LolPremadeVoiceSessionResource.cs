using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPremadeVoiceSessionResource
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("isMuted")]
        public bool IsMuted { get; set; }
        [JsonProperty("isTransmitEnabled")]
        public bool IsTransmitEnabled { get; set; }
        [JsonProperty("participants")]
        public LolPremadeVoiceParticipantResource[] Participants { get; set; }
        [JsonProperty("status")]
        public LolPremadeVoiceSessionStatus Status { get; set; }
        [JsonProperty("volume")]
        public int Volume { get; set; }
    }
}

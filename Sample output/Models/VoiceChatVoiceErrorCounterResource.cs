using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class VoiceChatVoiceErrorCounterResource
    {
        [JsonProperty("count")]
        public long Count { get; set; }
        [JsonProperty("error")]
        public VoiceChatVoiceErrorResource Error { get; set; }
        [JsonProperty("timeOfLastError")]
        public long TimeOfLastError { get; set; }
    }
}

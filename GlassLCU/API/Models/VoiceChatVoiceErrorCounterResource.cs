using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

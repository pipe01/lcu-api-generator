using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class GcloudVoiceChatVoiceErrorCounterResource
    {
        [JsonProperty("count")]
        public long Count { get; set; }
        [JsonProperty("error")]
        public GcloudVoiceChatVoiceErrorResource Error { get; set; }
        [JsonProperty("timeOfLastError")]
        public long TimeOfLastError { get; set; }
    }
}

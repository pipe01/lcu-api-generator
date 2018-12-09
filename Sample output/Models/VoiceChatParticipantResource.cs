using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class VoiceChatParticipantResource
    {
        [JsonProperty("energy")]
        public int Energy { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("isMuted")]
        public bool IsMuted { get; set; }
        [JsonProperty("isSpeaking")]
        public bool IsSpeaking { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("speakingTimestamp")]
        public int SpeakingTimestamp { get; set; }
        [JsonProperty("uri")]
        public string Uri { get; set; }
        [JsonProperty("volume")]
        public int Volume { get; set; }
    }
}
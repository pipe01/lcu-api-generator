using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPremadeVoiceParticipantResource
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
        [JsonProperty("volume")]
        public int Volume { get; set; }
    }
}

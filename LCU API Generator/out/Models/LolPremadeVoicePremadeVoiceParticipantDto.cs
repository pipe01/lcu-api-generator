using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPremadeVoicePremadeVoiceParticipantDto
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("energy")]
        public int Energy { get; set; }
        [JsonProperty("isMuted")]
        public bool IsMuted { get; set; }
        [JsonProperty("isSpeaking")]
        public bool IsSpeaking { get; set; }
        [JsonProperty("participantId")]
        public string ParticipantId { get; set; }
        [JsonProperty("puuid")]
        public string Puuid { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("volume")]
        public int Volume { get; set; }
    }
}

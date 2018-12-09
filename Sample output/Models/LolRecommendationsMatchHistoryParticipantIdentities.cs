using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRecommendationsMatchHistoryParticipantIdentities
    {
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }
        [JsonProperty("player")]
        public LolRecommendationsMatchHistoryParticipantIdentityPlayer Player { get; set; }
    }
}

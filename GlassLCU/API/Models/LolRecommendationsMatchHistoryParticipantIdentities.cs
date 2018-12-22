using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

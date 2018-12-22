using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMatchHistoryMatchHistoryTimeline
    {
        [JsonProperty("creepsPerMinDeltas")]
        public object CreepsPerMinDeltas { get; set; }
        [JsonProperty("csDiffPerMinDeltas")]
        public object CsDiffPerMinDeltas { get; set; }
        [JsonProperty("damageTakenDiffPerMinDeltas")]
        public object DamageTakenDiffPerMinDeltas { get; set; }
        [JsonProperty("damageTakenPerMinDeltas")]
        public object DamageTakenPerMinDeltas { get; set; }
        [JsonProperty("goldPerMinDeltas")]
        public object GoldPerMinDeltas { get; set; }
        [JsonProperty("lane")]
        public string Lane { get; set; }
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }
        [JsonProperty("role")]
        public string Role { get; set; }
        [JsonProperty("xpDiffPerMinDeltas")]
        public object XpDiffPerMinDeltas { get; set; }
        [JsonProperty("xpPerMinDeltas")]
        public object XpPerMinDeltas { get; set; }
    }
}

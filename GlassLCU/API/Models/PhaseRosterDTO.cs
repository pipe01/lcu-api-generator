using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PhaseRosterDTO
    {
        [JsonProperty("bracketDTO")]
        public Bracket BracketDTO { get; set; }
        [JsonProperty("bracketId")]
        public long BracketId { get; set; }
        [JsonProperty("period")]
        public int Period { get; set; }
        [JsonProperty("phaseId")]
        public long PhaseId { get; set; }
        [JsonProperty("phaseRosterSubs")]
        public PhaseRosterSubDTO[] PhaseRosterSubs { get; set; }
    }
}
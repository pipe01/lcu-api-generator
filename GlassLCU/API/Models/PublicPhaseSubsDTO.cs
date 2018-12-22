using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PublicPhaseSubsDTO
    {
        [JsonProperty("phaseId")]
        public long PhaseId { get; set; }
        [JsonProperty("phaseSubs")]
        public PublicPhaseSubDTO[] PhaseSubs { get; set; }
    }
}
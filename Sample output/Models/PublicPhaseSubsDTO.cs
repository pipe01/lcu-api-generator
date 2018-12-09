using Newtonsoft.Json;

namespace LCU_API_Generator
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

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderReadyStateV1
    {
        [JsonProperty("allowablePremadeSizes")]
        public int[] AllowablePremadeSizes { get; set; }
        [JsonProperty("premadeSizeAllowed")]
        public bool PremadeSizeAllowed { get; set; }
        [JsonProperty("readyToMatchmake")]
        public bool ReadyToMatchmake { get; set; }
        [JsonProperty("requiredPositionCoverageMet")]
        public bool RequiredPositionCoverageMet { get; set; }
    }
}

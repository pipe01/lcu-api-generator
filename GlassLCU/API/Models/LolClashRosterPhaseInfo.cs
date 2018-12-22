using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashRosterPhaseInfo
    {
        [JsonProperty("isBracketComplete")]
        public bool IsBracketComplete { get; set; }
        [JsonProperty("period")]
        public int Period { get; set; }
        [JsonProperty("phaseId")]
        public long PhaseId { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class MatchmakingLcdsQueueDodger
    {
        [JsonProperty("dodgePenaltyRemainingTime")]
        public long DodgePenaltyRemainingTime { get; set; }
        [JsonProperty("reasonFailed")]
        public string ReasonFailed { get; set; }
        [JsonProperty("summoner")]
        public MatchmakingLcdsSummoner Summoner { get; set; }
    }
}

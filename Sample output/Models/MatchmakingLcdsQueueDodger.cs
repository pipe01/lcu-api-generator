using Newtonsoft.Json;

namespace LCU_API_Generator
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

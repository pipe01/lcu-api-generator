using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPerksChampSelectTimer
    {
        [JsonProperty("adjustedTimeLeftInPhase")]
        public long AdjustedTimeLeftInPhase { get; set; }
        [JsonProperty("adjustedTimeLeftInPhaseInSec")]
        public int AdjustedTimeLeftInPhaseInSec { get; set; }
        [JsonProperty("internalNowInEpochMs")]
        public long InternalNowInEpochMs { get; set; }
        [JsonProperty("isInfinite")]
        public bool IsInfinite { get; set; }
        [JsonProperty("phase")]
        public string Phase { get; set; }
        [JsonProperty("timeLeftInPhase")]
        public long TimeLeftInPhase { get; set; }
        [JsonProperty("timeLeftInPhaseInSec")]
        public int TimeLeftInPhaseInSec { get; set; }
        [JsonProperty("totalTimeInPhase")]
        public long TotalTimeInPhase { get; set; }
    }
}

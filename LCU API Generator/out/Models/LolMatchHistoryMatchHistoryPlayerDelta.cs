using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMatchHistoryMatchHistoryPlayerDelta
    {
        [JsonProperty("deltas")]
        public LolMatchHistoryMatchHistoryPlayerGameDelta[] Deltas { get; set; }
        [JsonProperty("originalAccountId")]
        public long OriginalAccountId { get; set; }
        [JsonProperty("originalPlatformId")]
        public string OriginalPlatformId { get; set; }
    }
}

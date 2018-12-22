using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

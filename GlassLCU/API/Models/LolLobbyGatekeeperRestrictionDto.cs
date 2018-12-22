using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyGatekeeperRestrictionDto
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("payload")]
        public string Payload { get; set; }
        [JsonProperty("puuid")]
        public string Puuid { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
        [JsonProperty("remainingMillis")]
        public long RemainingMillis { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderGatekeeperRestriction
    {
        [JsonProperty("payload")]
        public string Payload { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
        [JsonProperty("remainingMillis")]
        public int RemainingMillis { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

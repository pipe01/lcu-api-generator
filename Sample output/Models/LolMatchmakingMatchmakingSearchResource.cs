//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMatchmakingMatchmakingSearchResource
    {
        [JsonProperty("dodgeData")]
        public LolMatchmakingMatchmakingDodgeData DodgeData { get; set; }
        [JsonProperty("errors")]
        public LolMatchmakingMatchmakingSearchErrorResource[] Errors { get; set; }
        [JsonProperty("estimatedQueueTime")]
        public float EstimatedQueueTime { get; set; }
        [JsonProperty("isCurrentlyInQueue")]
        public bool IsCurrentlyInQueue { get; set; }
        [JsonProperty("lobbyId")]
        public string LobbyId { get; set; }
        [JsonProperty("lowPriorityData")]
        public LolMatchmakingMatchmakingLowPriorityData LowPriorityData { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("readyCheck")]
        public LolMatchmakingMatchmakingReadyCheckResource ReadyCheck { get; set; }
        [JsonProperty("searchState")]
        public LolMatchmakingMatchmakingSearchState SearchState { get; set; }
        [JsonProperty("timeInQueue")]
        public float TimeInQueue { get; set; }
    }
}

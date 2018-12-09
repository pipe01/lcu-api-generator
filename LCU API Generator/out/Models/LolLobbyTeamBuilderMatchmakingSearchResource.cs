using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderMatchmakingSearchResource
    {
        [JsonProperty("dodgeData")]
        public LolLobbyTeamBuilderMatchmakingDodgeData DodgeData { get; set; }
        [JsonProperty("errors")]
        public LolLobbyTeamBuilderMatchmakingSearchErrorResource[] Errors { get; set; }
        [JsonProperty("estimatedQueueTime")]
        public float EstimatedQueueTime { get; set; }
        [JsonProperty("isCurrentlyInQueue")]
        public bool IsCurrentlyInQueue { get; set; }
        [JsonProperty("lobbyId")]
        public string LobbyId { get; set; }
        [JsonProperty("lowPriorityData")]
        public LolLobbyTeamBuilderMatchmakingLowPriorityData LowPriorityData { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
        [JsonProperty("readyCheck")]
        public LolLobbyTeamBuilderMatchmakingReadyCheckResource ReadyCheck { get; set; }
        [JsonProperty("searchState")]
        public LolLobbyTeamBuilderMatchmakingSearchState SearchState { get; set; }
        [JsonProperty("timeInQueue")]
        public float TimeInQueue { get; set; }
    }
}

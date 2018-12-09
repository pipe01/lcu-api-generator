using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampSelectLegacyLobbyStatus
    {
        [JsonProperty("allowedPlayAgain")]
        public bool AllowedPlayAgain { get; set; }
        [JsonProperty("isCustom")]
        public bool IsCustom { get; set; }
        [JsonProperty("isLeader")]
        public bool IsLeader { get; set; }
        [JsonProperty("isSpectator")]
        public bool IsSpectator { get; set; }
        [JsonProperty("memberSummonerIds")]
        public long[] MemberSummonerIds { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
    }
}

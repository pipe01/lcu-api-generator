using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSuggestedPlayersSuggestedPlayersLobbyStatus
    {
        [JsonProperty("invitedSummonerIds")]
        public long[] InvitedSummonerIds { get; set; }
        [JsonProperty("memberSummonerIds")]
        public long[] MemberSummonerIds { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
    }
}

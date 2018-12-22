using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolSuggestedPlayersSuggestedPlayersSuggestedPlayer
    {
        [JsonProperty("commonFriendId")]
        public long CommonFriendId { get; set; }
        [JsonProperty("commonFriendName")]
        public string CommonFriendName { get; set; }
        [JsonProperty("reason")]
        public LolSuggestedPlayersSuggestedPlayersReason Reason { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
    }
}
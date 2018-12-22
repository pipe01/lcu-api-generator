using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyLobbyMatchmakingSearchResource
    {
        [JsonProperty("errors")]
        public LolLobbyLobbyMatchmakingSearchErrorResource[] Errors { get; set; }
        [JsonProperty("lowPriorityData")]
        public LolLobbyLobbyMatchmakingLowPriorityDataResource LowPriorityData { get; set; }
        [JsonProperty("searchState")]
        public LolLobbyLobbyMatchmakingSearchState SearchState { get; set; }
    }
}
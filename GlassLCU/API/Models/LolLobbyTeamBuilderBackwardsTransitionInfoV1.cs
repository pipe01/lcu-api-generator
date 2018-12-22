using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderBackwardsTransitionInfoV1
    {
        [JsonProperty("backwardsTransitionReason")]
        public string BackwardsTransitionReason { get; set; }
        [JsonProperty("initiatorSummonerIds")]
        public long[] InitiatorSummonerIds { get; set; }
    }
}

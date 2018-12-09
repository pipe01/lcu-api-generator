using Newtonsoft.Json;

namespace LCU_API_Generator
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

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderTbRemovedFromServiceNotification
    {
        [JsonProperty("backwardsTransitionInfo")]
        public LolLobbyTeamBuilderBackwardsTransitionInfoV1 BackwardsTransitionInfo { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}

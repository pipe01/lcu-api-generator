//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

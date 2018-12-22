using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderTbLobbyBackwardsToPremadeTransitionResource
    {
        [JsonProperty("backwardsTransitionReason")]
        public string BackwardsTransitionReason { get; set; }
        [JsonProperty("slotIds")]
        public int[] SlotIds { get; set; }
    }
}

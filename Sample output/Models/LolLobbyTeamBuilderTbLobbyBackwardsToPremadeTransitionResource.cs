using Newtonsoft.Json;

namespace LCU_API_Generator
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

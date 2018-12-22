using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderAfkCheckStateV1
    {
        [JsonProperty("afkReady")]
        public bool AfkReady { get; set; }
        [JsonProperty("inventoryDraft")]
        public LolLobbyTeamBuilderTbdInventory InventoryDraft { get; set; }
        [JsonProperty("maxAfkMillis")]
        public int MaxAfkMillis { get; set; }
        [JsonProperty("remainingAfkMillis")]
        public int RemainingAfkMillis { get; set; }
    }
}

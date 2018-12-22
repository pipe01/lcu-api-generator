using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolModeProgressionLoadoutsSlot
    {
        [JsonProperty("inventoryType")]
        public string InventoryType { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
    }
}

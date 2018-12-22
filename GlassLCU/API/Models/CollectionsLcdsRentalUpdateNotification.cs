using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class CollectionsLcdsRentalUpdateNotification
    {
        [JsonProperty("data")]
        public object Data { get; set; }
        [JsonProperty("inventoryType")]
        public string InventoryType { get; set; }
    }
}
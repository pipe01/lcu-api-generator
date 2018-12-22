using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolInventoryInventoryNotification
    {
        [JsonProperty("acknowledged")]
        public bool Acknowledged { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("inventoryType")]
        public string InventoryType { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

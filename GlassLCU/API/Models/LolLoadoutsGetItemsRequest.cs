using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLoadoutsGetItemsRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("inventoryJWTs")]
        public string[] InventoryJWTs { get; set; }
        [JsonProperty("inventoryTypes")]
        public string[] InventoryTypes { get; set; }
    }
}

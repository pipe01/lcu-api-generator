using Newtonsoft.Json;

namespace LCU_API_Generator
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

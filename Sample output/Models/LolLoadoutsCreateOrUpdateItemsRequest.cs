using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLoadoutsCreateOrUpdateItemsRequest
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("inventoryJWTs")]
        public string[] InventoryJWTs { get; set; }
        [JsonProperty("items")]
        public object Items { get; set; }
    }
}

//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

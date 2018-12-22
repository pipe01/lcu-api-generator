using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolInventoryRmsEntitlementPayload
    {
        [JsonProperty("itemId")]
        public string ItemId { get; set; }
        [JsonProperty("itemTypeId")]
        public string ItemTypeId { get; set; }
        [JsonProperty("resourceOperation")]
        public string ResourceOperation { get; set; }
    }
}

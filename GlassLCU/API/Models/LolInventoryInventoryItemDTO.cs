using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolInventoryInventoryItemDTO
    {
        [JsonProperty("entitlementId")]
        public string EntitlementId { get; set; }
        [JsonProperty("entitlementTypeId")]
        public string EntitlementTypeId { get; set; }
        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
        [JsonProperty("f2p")]
        public bool F2p { get; set; }
        [JsonProperty("instanceId")]
        public string InstanceId { get; set; }
        [JsonProperty("instanceTypeId")]
        public string InstanceTypeId { get; set; }
        [JsonProperty("inventoryType")]
        public string InventoryType { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("loyalty")]
        public bool Loyalty { get; set; }
        [JsonProperty("lsb")]
        public bool Lsb { get; set; }
        [JsonProperty("payload")]
        public object Payload { get; set; }
        [JsonProperty("purchaseDate")]
        public string PurchaseDate { get; set; }
        [JsonProperty("quantity")]
        public long Quantity { get; set; }
        [JsonProperty("rental")]
        public bool Rental { get; set; }
        [JsonProperty("usedInGameDate")]
        public string UsedInGameDate { get; set; }
        [JsonProperty("wins")]
        public long Wins { get; set; }
    }
}

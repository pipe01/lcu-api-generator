using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCatalogCatalogPluginItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("imagePath")]
        public string ImagePath { get; set; }
        [JsonProperty("inactiveDate")]
        public long InactiveDate { get; set; }
        [JsonProperty("inventoryType")]
        public string InventoryType { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("itemInstanceId")]
        public string ItemInstanceId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("owned")]
        public bool Owned { get; set; }
        [JsonProperty("prices")]
        public LolCatalogCatalogPluginPrice[] Prices { get; set; }
        [JsonProperty("purchaseDate")]
        public long PurchaseDate { get; set; }
        [JsonProperty("releaseDate")]
        public long ReleaseDate { get; set; }
    }
}

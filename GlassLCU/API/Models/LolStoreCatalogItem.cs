using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolStoreCatalogItem
    {
        [JsonProperty("active")]
        public bool Active { get; set; }
        [JsonProperty("bundled")]
        public LolStoreBundled Bundled { get; set; }
        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }
        [JsonProperty("inactiveDate")]
        public string InactiveDate { get; set; }
        [JsonProperty("inventoryType")]
        public string InventoryType { get; set; }
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("itemInstanceId")]
        public string ItemInstanceId { get; set; }
        [JsonProperty("itemRequirements")]
        public LolStoreItemKey[] ItemRequirements { get; set; }
        [JsonProperty("localizations")]
        public object Localizations { get; set; }
        [JsonProperty("maxQuantity")]
        public int MaxQuantity { get; set; }
        [JsonProperty("prices")]
        public LolStoreItemCost[] Prices { get; set; }
        [JsonProperty("releaseDate")]
        public string ReleaseDate { get; set; }
        [JsonProperty("sale")]
        public LolStoreSale Sale { get; set; }
        [JsonProperty("subInventoryType")]
        public string SubInventoryType { get; set; }
        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }
}
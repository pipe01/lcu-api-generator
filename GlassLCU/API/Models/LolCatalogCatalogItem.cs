using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCatalogCatalogItem
    {
        [JsonProperty("active")]
        public bool Active { get; set; }
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
        [JsonProperty("localizations")]
        public object Localizations { get; set; }
        [JsonProperty("prices")]
        public LolCatalogItemCost[] Prices { get; set; }
        [JsonProperty("releaseDate")]
        public string ReleaseDate { get; set; }
        [JsonProperty("sale")]
        public LolCatalogSale Sale { get; set; }
        [JsonProperty("subInventoryType")]
        public string SubInventoryType { get; set; }
        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }
}

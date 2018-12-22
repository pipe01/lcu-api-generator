using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootLootItem
    {
        [JsonProperty("asset")]
        public string Asset { get; set; }
        [JsonProperty("displayCategories")]
        public string DisplayCategories { get; set; }
        [JsonProperty("expiryTime")]
        public long ExpiryTime { get; set; }
        [JsonProperty("lootName")]
        public string LootName { get; set; }
        [JsonProperty("rarity")]
        public string Rarity { get; set; }
        [JsonProperty("rentalGames")]
        public int RentalGames { get; set; }
        [JsonProperty("rentalSeconds")]
        public long RentalSeconds { get; set; }
        [JsonProperty("storeItemId")]
        public int StoreItemId { get; set; }
        [JsonProperty("tags")]
        public string Tags { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("upgradeLootName")]
        public string UpgradeLootName { get; set; }
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
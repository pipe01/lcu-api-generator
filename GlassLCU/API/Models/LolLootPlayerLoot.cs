using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootPlayerLoot
    {
        [JsonProperty("asset")]
        public string Asset { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("disenchantLootName")]
        public string DisenchantLootName { get; set; }
        [JsonProperty("disenchantValue")]
        public int DisenchantValue { get; set; }
        [JsonProperty("displayCategories")]
        public string DisplayCategories { get; set; }
        [JsonProperty("expiryTime")]
        public long ExpiryTime { get; set; }
        [JsonProperty("isNew")]
        public bool IsNew { get; set; }
        [JsonProperty("isRental")]
        public bool IsRental { get; set; }
        [JsonProperty("itemDesc")]
        public string ItemDesc { get; set; }
        [JsonProperty("itemStatus")]
        public LolLootItemOwnershipStatus ItemStatus { get; set; }
        [JsonProperty("localizedDescription")]
        public string LocalizedDescription { get; set; }
        [JsonProperty("localizedName")]
        public string LocalizedName { get; set; }
        [JsonProperty("localizedRecipeSubtitle")]
        public string LocalizedRecipeSubtitle { get; set; }
        [JsonProperty("localizedRecipeTitle")]
        public string LocalizedRecipeTitle { get; set; }
        [JsonProperty("lootId")]
        public string LootId { get; set; }
        [JsonProperty("lootName")]
        public string LootName { get; set; }
        [JsonProperty("parentItemStatus")]
        public LolLootItemOwnershipStatus ParentItemStatus { get; set; }
        [JsonProperty("parentStoreItemId")]
        public int ParentStoreItemId { get; set; }
        [JsonProperty("rarity")]
        public string Rarity { get; set; }
        [JsonProperty("redeemableStatus")]
        public LolLootRedeemableStatus RedeemableStatus { get; set; }
        [JsonProperty("refId")]
        public string RefId { get; set; }
        [JsonProperty("rentalGames")]
        public int RentalGames { get; set; }
        [JsonProperty("rentalSeconds")]
        public long RentalSeconds { get; set; }
        [JsonProperty("shadowPath")]
        public string ShadowPath { get; set; }
        [JsonProperty("splashPath")]
        public string SplashPath { get; set; }
        [JsonProperty("storeItemId")]
        public int StoreItemId { get; set; }
        [JsonProperty("tags")]
        public string Tags { get; set; }
        [JsonProperty("tilePath")]
        public string TilePath { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("upgradeEssenceName")]
        public string UpgradeEssenceName { get; set; }
        [JsonProperty("upgradeEssenceValue")]
        public int UpgradeEssenceValue { get; set; }
        [JsonProperty("upgradeLootName")]
        public string UpgradeLootName { get; set; }
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}

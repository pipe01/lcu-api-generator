using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LootLcdsClientConfigurationDTO
    {
        [JsonProperty("currenciesUsingCapWallets")]
        public string[] CurrenciesUsingCapWallets { get; set; }
        [JsonProperty("lootItemsUsingBreakoutRecipeMenu")]
        public string[] LootItemsUsingBreakoutRecipeMenu { get; set; }
        [JsonProperty("lootMaterialsToAlwaysRender")]
        public string[] LootMaterialsToAlwaysRender { get; set; }
    }
}

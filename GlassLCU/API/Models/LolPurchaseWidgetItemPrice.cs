using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPurchaseWidgetItemPrice
    {
        [JsonProperty("currencyType")]
        public string CurrencyType { get; set; }
        [JsonProperty("price")]
        public int Price { get; set; }
        [JsonProperty("purchasable")]
        public bool Purchasable { get; set; }
    }
}

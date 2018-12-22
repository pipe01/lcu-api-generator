using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPurchaseWidgetBalance
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }
        [JsonProperty("currencyType")]
        public string CurrencyType { get; set; }
    }
}

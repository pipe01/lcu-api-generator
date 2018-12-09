using Newtonsoft.Json;

namespace LCU_API_Generator
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

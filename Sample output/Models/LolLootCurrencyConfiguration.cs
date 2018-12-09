using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLootCurrencyConfiguration
    {
        [JsonProperty("currenciesUsingCapWallets")]
        public string[] CurrenciesUsingCapWallets { get; set; }
    }
}

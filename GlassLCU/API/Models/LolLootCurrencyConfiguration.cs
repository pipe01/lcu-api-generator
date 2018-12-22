using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootCurrencyConfiguration
    {
        [JsonProperty("currenciesUsingCapWallets")]
        public string[] CurrenciesUsingCapWallets { get; set; }
    }
}

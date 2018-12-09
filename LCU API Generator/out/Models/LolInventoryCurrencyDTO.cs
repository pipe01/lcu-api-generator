using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolInventoryCurrencyDTO
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }
        [JsonProperty("subCurrencies")]
        public object SubCurrencies { get; set; }
    }
}

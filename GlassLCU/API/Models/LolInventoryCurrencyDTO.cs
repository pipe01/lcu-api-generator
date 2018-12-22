using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

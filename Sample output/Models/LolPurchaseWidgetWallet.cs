//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPurchaseWidgetWallet
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("balances")]
        public LolPurchaseWidgetBalance[] Balances { get; set; }
        [JsonProperty("version")]
        public int Version { get; set; }
    }
}

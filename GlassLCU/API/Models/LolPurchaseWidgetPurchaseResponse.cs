using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPurchaseWidgetPurchaseResponse
    {
        [JsonProperty("items")]
        public LolPurchaseWidgetPurchaseItem[] Items { get; set; }
        [JsonProperty("transactions")]
        public LolPurchaseWidgetTransaction[] Transactions { get; set; }
        [JsonProperty("wallet")]
        public LolPurchaseWidgetWallet Wallet { get; set; }
    }
}

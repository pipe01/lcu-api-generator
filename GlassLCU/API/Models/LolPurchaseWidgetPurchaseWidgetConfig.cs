using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPurchaseWidgetPurchaseWidgetConfig
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("purchaseDisclaimerEnabled")]
        public bool PurchaseDisclaimerEnabled { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPurchaseWidgetPurchaseRequest
    {
        [JsonProperty("items")]
        public LolPurchaseWidgetPurchaseItem[] Items { get; set; }
    }
}

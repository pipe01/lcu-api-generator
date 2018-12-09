using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPurchaseWidgetPurchaseRequest
    {
        [JsonProperty("items")]
        public LolPurchaseWidgetPurchaseItem[] Items { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPurchaseWidgetValidationRequest
    {
        [JsonProperty("items")]
        public LolPurchaseWidgetValidationRequestItem[] Items { get; set; }
    }
}

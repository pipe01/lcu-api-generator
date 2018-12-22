using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPurchaseWidgetValidationRequest
    {
        [JsonProperty("items")]
        public LolPurchaseWidgetValidationRequestItem[] Items { get; set; }
    }
}

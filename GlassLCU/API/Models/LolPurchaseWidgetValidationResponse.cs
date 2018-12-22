using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPurchaseWidgetValidationResponse
    {
        [JsonProperty("items")]
        public LolPurchaseWidgetValidationResponseItem[] Items { get; set; }
        [JsonProperty("valid")]
        public bool Valid { get; set; }
    }
}

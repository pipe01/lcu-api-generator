using Newtonsoft.Json;

namespace LCU_API_Generator
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

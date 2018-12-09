using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolBannersTournamentFrameInventoryItem
    {
        [JsonProperty("payload")]
        public LolBannersCapClashFrameEntitlementPayload Payload { get; set; }
        [JsonProperty("purchaseDate")]
        public string PurchaseDate { get; set; }
    }
}

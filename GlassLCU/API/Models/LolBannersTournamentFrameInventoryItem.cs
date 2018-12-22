using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

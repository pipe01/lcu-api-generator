using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolBannersTournamentFlagInventoryItem
    {
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("payload")]
        public LolBannersCapClashFlagEntitlementPayload Payload { get; set; }
        [JsonProperty("purchaseDate")]
        public string PurchaseDate { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolTrophiesTournamentTrophyInventoryItem
    {
        [JsonProperty("payload")]
        public LolTrophiesCapClashTrophyEntitlementPayload Payload { get; set; }
        [JsonProperty("purchaseDate")]
        public string PurchaseDate { get; set; }
    }
}

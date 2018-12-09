using Newtonsoft.Json;

namespace LCU_API_Generator
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

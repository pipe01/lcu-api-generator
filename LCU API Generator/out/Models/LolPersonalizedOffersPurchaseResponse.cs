using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPersonalizedOffersPurchaseResponse
    {
        [JsonProperty("items")]
        public LolPersonalizedOffersPurchaseItem[] Items { get; set; }
        [JsonProperty("wallet")]
        public LolPersonalizedOffersWallet Wallet { get; set; }
    }
}

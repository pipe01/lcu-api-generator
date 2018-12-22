using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

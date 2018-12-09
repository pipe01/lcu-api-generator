using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPersonalizedOffersOfferData
    {
        [JsonProperty("offers")]
        public LolPersonalizedOffersOffer[] Offers { get; set; }
        [JsonProperty("promotion")]
        public LolPersonalizedOffersPromotion Promotion { get; set; }
    }
}

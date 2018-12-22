using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

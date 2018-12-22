using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPersonalizedOffersOfferIds
    {
        [JsonProperty("offers")]
        public LolPersonalizedOffersOfferId[] Offers { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPersonalizedOffersOfferRequests
    {
        [JsonProperty("offers")]
        public LolPersonalizedOffersOfferRequest[] Offers { get; set; }
    }
}

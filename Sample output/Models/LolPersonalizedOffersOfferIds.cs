using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPersonalizedOffersOfferIds
    {
        [JsonProperty("offers")]
        public LolPersonalizedOffersOfferId[] Offers { get; set; }
    }
}

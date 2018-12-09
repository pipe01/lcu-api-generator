using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPersonalizedOffersOfferRequests
    {
        [JsonProperty("offers")]
        public LolPersonalizedOffersOfferRequest[] Offers { get; set; }
    }
}

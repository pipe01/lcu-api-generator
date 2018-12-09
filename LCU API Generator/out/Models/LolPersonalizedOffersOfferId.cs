using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPersonalizedOffersOfferId
    {
        [JsonProperty("offerId")]
        public string OfferId { get; set; }
    }
}

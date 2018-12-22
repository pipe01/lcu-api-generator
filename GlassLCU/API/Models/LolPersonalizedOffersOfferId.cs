using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPersonalizedOffersOfferId
    {
        [JsonProperty("offerId")]
        public string OfferId { get; set; }
    }
}

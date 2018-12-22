using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolQueueEligibilityCollectionsRental
    {
        [JsonProperty("rented")]
        public bool Rented { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolQueueEligibilityCollectionsRental
    {
        [JsonProperty("rented")]
        public bool Rented { get; set; }
    }
}

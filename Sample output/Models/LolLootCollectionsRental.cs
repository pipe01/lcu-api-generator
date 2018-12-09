using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLootCollectionsRental
    {
        [JsonProperty("rented")]
        public bool Rented { get; set; }
    }
}

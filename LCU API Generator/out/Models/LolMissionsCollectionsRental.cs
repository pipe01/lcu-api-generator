using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMissionsCollectionsRental
    {
        [JsonProperty("rented")]
        public bool Rented { get; set; }
    }
}

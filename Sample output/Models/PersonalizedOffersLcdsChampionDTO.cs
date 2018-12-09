using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PersonalizedOffersLcdsChampionDTO
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("owned")]
        public bool Owned { get; set; }
    }
}

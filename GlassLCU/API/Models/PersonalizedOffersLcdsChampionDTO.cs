using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

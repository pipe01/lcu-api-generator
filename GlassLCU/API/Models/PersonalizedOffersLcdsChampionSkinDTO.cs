using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PersonalizedOffersLcdsChampionSkinDTO
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("owned")]
        public bool Owned { get; set; }
        [JsonProperty("skinId")]
        public int SkinId { get; set; }
    }
}

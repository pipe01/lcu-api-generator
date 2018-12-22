using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootCollectionsChampionSkinMinimal
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("ownership")]
        public LolLootCollectionsOwnership Ownership { get; set; }
        [JsonProperty("splashPath")]
        public string SplashPath { get; set; }
        [JsonProperty("tilePath")]
        public string TilePath { get; set; }
    }
}
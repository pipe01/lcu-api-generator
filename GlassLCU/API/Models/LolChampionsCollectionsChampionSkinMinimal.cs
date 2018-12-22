using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampionsCollectionsChampionSkinMinimal
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("chromaPath")]
        public string ChromaPath { get; set; }
        [JsonProperty("disabled")]
        public bool Disabled { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("isBase")]
        public bool IsBase { get; set; }
        [JsonProperty("lastSelected")]
        public bool LastSelected { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("ownership")]
        public LolChampionsCollectionsOwnership Ownership { get; set; }
        [JsonProperty("splashPath")]
        public string SplashPath { get; set; }
        [JsonProperty("stillObtainable")]
        public bool StillObtainable { get; set; }
        [JsonProperty("tilePath")]
        public string TilePath { get; set; }
    }
}

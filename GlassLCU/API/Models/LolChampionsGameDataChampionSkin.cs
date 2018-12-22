using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampionsGameDataChampionSkin
    {
        [JsonProperty("cardPath")]
        public string CardPath { get; set; }
        [JsonProperty("chromaPath")]
        public string ChromaPath { get; set; }
        [JsonProperty("chromas")]
        public LolChampionsGameDataChampionChroma[] Chromas { get; set; }
        [JsonProperty("emblems")]
        public LolChampionsCollectionsChampionSkinEmblem[] Emblems { get; set; }
        [JsonProperty("featuresText")]
        public string FeaturesText { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("rarityGemPath")]
        public string RarityGemPath { get; set; }
        [JsonProperty("skinType")]
        public string SkinType { get; set; }
        [JsonProperty("splashPath")]
        public string SplashPath { get; set; }
        [JsonProperty("splashVideoPath")]
        public string SplashVideoPath { get; set; }
        [JsonProperty("tilePath")]
        public string TilePath { get; set; }
        [JsonProperty("uncenteredSplashPath")]
        public string UncenteredSplashPath { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampionsCollectionsChampionSkin
    {
        [JsonProperty("cardPath")]
        public string CardPath { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("chromaPath")]
        public string ChromaPath { get; set; }
        [JsonProperty("chromas")]
        public LolChampionsCollectionsChampionChroma[] Chromas { get; set; }
        [JsonProperty("disabled")]
        public bool Disabled { get; set; }
        [JsonProperty("emblems")]
        public LolChampionsCollectionsChampionSkinEmblem[] Emblems { get; set; }
        [JsonProperty("featuresText")]
        public string FeaturesText { get; set; }
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
        [JsonProperty("rarityGemPath")]
        public string RarityGemPath { get; set; }
        [JsonProperty("skinType")]
        public string SkinType { get; set; }
        [JsonProperty("splashPath")]
        public string SplashPath { get; set; }
        [JsonProperty("splashVideoPath")]
        public string SplashVideoPath { get; set; }
        [JsonProperty("stillObtainable")]
        public bool StillObtainable { get; set; }
        [JsonProperty("tilePath")]
        public string TilePath { get; set; }
        [JsonProperty("uncenteredSplashPath")]
        public string UncenteredSplashPath { get; set; }
    }
}

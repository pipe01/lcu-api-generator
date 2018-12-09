using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRecommendationsCollectionsChampionSkinMinimal
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
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
        public LolRecommendationsCollectionsOwnership Ownership { get; set; }
        [JsonProperty("stillObtainable")]
        public bool StillObtainable { get; set; }
    }
}

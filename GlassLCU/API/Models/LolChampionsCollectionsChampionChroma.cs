using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampionsCollectionsChampionChroma
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("chromaPath")]
        public string ChromaPath { get; set; }
        [JsonProperty("colors")]
        public string[] Colors { get; set; }
        [JsonProperty("disabled")]
        public bool Disabled { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("lastSelected")]
        public bool LastSelected { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("ownership")]
        public LolChampionsCollectionsOwnership Ownership { get; set; }
        [JsonProperty("stillObtainable")]
        public bool StillObtainable { get; set; }
    }
}

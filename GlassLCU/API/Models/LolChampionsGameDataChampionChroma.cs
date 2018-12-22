using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampionsGameDataChampionChroma
    {
        [JsonProperty("chromaPath")]
        public string ChromaPath { get; set; }
        [JsonProperty("colors")]
        public string[] Colors { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}

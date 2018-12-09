using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsGameDataChampionSkin
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("isBase")]
        public bool IsBase { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("splashPath")]
        public string SplashPath { get; set; }
        [JsonProperty("splashVideoPath")]
        public string SplashVideoPath { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampionsGameDataChampionTacticalInfo
    {
        [JsonProperty("damageType")]
        public string DamageType { get; set; }
        [JsonProperty("difficulty")]
        public int Difficulty { get; set; }
        [JsonProperty("style")]
        public int Style { get; set; }
    }
}

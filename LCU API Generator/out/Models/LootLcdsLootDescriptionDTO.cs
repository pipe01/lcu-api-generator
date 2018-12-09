using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LootLcdsLootDescriptionDTO
    {
        [JsonProperty("childLootTableNames")]
        public string[] ChildLootTableNames { get; set; }
        [JsonProperty("localizationLongDescriptionMap")]
        public object LocalizationLongDescriptionMap { get; set; }
        [JsonProperty("localizationMap")]
        public object LocalizationMap { get; set; }
        [JsonProperty("lootName")]
        public string LootName { get; set; }
    }
}

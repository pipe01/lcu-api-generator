using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class CraftLootRefTransactionDTO
    {
        [JsonProperty("lootNameRefIds")]
        public LootNameRefId[] LootNameRefIds { get; set; }
        [JsonProperty("recipeName")]
        public string RecipeName { get; set; }
        [JsonProperty("repeat")]
        public int Repeat { get; set; }
    }
}

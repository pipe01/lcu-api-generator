//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

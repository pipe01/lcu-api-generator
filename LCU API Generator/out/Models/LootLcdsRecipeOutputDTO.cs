using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LootLcdsRecipeOutputDTO
    {
        [JsonProperty("allowDuplicates")]
        public bool AllowDuplicates { get; set; }
        [JsonProperty("lootName")]
        public string LootName { get; set; }
        [JsonProperty("probability")]
        public float Probability { get; set; }
        [JsonProperty("quantityExpression")]
        public string QuantityExpression { get; set; }
    }
}

//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

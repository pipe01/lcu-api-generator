using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LootLcdsRecipeSlotClientDTO
    {
        [JsonProperty("quantityExpression")]
        public string QuantityExpression { get; set; }
        [JsonProperty("query")]
        public string Query { get; set; }
        [JsonProperty("slotNumber")]
        public int SlotNumber { get; set; }
    }
}

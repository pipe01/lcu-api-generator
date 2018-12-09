using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RedeemLootTransactionDTO
    {
        [JsonProperty("lootName")]
        public string LootName { get; set; }
    }
}

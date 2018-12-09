using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolWorldsTokenCardLootDataGdsResource
    {
        [JsonProperty("LootTokenBankCards")]
        public LolWorldsTokenCardLootTokenBankCardGdsResource[] LootTokenBankCards { get; set; }
    }
}

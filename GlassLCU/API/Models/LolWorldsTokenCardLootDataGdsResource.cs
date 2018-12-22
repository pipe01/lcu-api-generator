using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolWorldsTokenCardLootDataGdsResource
    {
        [JsonProperty("LootTokenBankCards")]
        public LolWorldsTokenCardLootTokenBankCardGdsResource[] LootTokenBankCards { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLootCollectionsEmote
    {
        [JsonProperty("itemId")]
        public long ItemId { get; set; }
        [JsonProperty("ownershipType")]
        public LolLootInventoryOwnership OwnershipType { get; set; }
    }
}

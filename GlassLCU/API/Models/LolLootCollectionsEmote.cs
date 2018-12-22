using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

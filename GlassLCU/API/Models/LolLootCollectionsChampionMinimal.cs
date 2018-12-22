using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootCollectionsChampionMinimal
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("ownership")]
        public LolLootCollectionsOwnership Ownership { get; set; }
    }
}

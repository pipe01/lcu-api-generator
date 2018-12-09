using Newtonsoft.Json;

namespace LCU_API_Generator
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

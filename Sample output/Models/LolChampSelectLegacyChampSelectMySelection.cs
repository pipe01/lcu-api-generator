using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampSelectLegacyChampSelectMySelection
    {
        [JsonProperty("selectedSkinId")]
        public int SelectedSkinId { get; set; }
        [JsonProperty("spell1Id")]
        public long Spell1Id { get; set; }
        [JsonProperty("spell2Id")]
        public long Spell2Id { get; set; }
        [JsonProperty("wardSkinId")]
        public long WardSkinId { get; set; }
    }
}

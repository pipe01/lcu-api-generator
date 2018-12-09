using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class CollectionsLcdsSlotEntry
    {
        [JsonProperty("runeId")]
        public int RuneId { get; set; }
        [JsonProperty("runeSlotId")]
        public int RuneSlotId { get; set; }
    }
}

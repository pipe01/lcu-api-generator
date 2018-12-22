using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPerksPerkStyleSlotResource
    {
        [JsonProperty("perks")]
        public int[] Perks { get; set; }
        [JsonProperty("slotLabel")]
        public string SlotLabel { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

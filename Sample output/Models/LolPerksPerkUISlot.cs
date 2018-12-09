using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPerksPerkUISlot
    {
        [JsonProperty("perks")]
        public int[] Perks { get; set; }
        [JsonProperty("slotLabel")]
        public string SlotLabel { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

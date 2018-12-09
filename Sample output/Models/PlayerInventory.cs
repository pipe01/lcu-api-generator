using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PlayerInventory
    {
        [JsonProperty("champions")]
        public int[] Champions { get; set; }
        [JsonProperty("icons")]
        public int[] Icons { get; set; }
        [JsonProperty("skins")]
        public int[] Skins { get; set; }
        [JsonProperty("wardSkins")]
        public long[] WardSkins { get; set; }
    }
}

//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

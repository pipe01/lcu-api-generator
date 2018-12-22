using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPerksPerkSubStyleBonusResource
    {
        [JsonProperty("perkId")]
        public int PerkId { get; set; }
        [JsonProperty("styleId")]
        public int StyleId { get; set; }
    }
}

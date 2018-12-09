using Newtonsoft.Json;

namespace LCU_API_Generator
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

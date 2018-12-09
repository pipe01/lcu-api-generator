using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPerksPerkSettingResource
    {
        [JsonProperty("perkIds")]
        public int[] PerkIds { get; set; }
        [JsonProperty("perkStyle")]
        public int PerkStyle { get; set; }
        [JsonProperty("perkSubStyle")]
        public int PerkSubStyle { get; set; }
    }
}

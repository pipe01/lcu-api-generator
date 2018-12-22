using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

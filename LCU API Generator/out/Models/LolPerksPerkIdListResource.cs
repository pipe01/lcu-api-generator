using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPerksPerkIdListResource
    {
        [JsonProperty("perkIds")]
        public int[] PerkIds { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPerksPerkIdListResource
    {
        [JsonProperty("perkIds")]
        public int[] PerkIds { get; set; }
    }
}

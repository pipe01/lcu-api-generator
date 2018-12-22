using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampSelectChampSelectPickableSkins
    {
        [JsonProperty("skinIds")]
        public int[] SkinIds { get; set; }
    }
}

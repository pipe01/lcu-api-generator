using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampSelectChampSelectPickableSkins
    {
        [JsonProperty("skinIds")]
        public int[] SkinIds { get; set; }
    }
}

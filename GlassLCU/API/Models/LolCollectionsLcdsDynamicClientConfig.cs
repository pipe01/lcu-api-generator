using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCollectionsLcdsDynamicClientConfig
    {
        [JsonProperty("DisabledChampions")]
        public object DisabledChampions { get; set; }
    }
}

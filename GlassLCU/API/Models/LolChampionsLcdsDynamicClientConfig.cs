using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampionsLcdsDynamicClientConfig
    {
        [JsonProperty("DisabledChampions")]
        public object DisabledChampions { get; set; }
    }
}

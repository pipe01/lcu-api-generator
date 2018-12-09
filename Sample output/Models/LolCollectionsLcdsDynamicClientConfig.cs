using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsLcdsDynamicClientConfig
    {
        [JsonProperty("DisabledChampions")]
        public object DisabledChampions { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampionsLcdsDynamicClientConfig
    {
        [JsonProperty("DisabledChampions")]
        public object DisabledChampions { get; set; }
    }
}

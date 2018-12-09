using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LCDSGlobalRewards
    {
        [JsonProperty("allChampions")]
        public bool AllChampions { get; set; }
    }
}

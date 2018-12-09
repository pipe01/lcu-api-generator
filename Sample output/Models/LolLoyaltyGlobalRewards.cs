using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLoyaltyGlobalRewards
    {
        [JsonProperty("allChampions")]
        public bool AllChampions { get; set; }
    }
}

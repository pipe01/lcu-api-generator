using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMatchHistoryMatchHistoryPlayerChampMasteryDelta
    {
        [JsonProperty("grade")]
        public string Grade { get; set; }
    }
}

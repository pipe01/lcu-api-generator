using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashGameflowAvailability
    {
        [JsonProperty("isAvailable")]
        public bool IsAvailable { get; set; }
    }
}

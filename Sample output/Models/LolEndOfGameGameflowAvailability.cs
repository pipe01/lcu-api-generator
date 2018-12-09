using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolEndOfGameGameflowAvailability
    {
        [JsonProperty("state")]
        public string State { get; set; }
    }
}

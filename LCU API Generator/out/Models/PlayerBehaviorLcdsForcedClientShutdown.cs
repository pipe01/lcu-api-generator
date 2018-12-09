using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PlayerBehaviorLcdsForcedClientShutdown
    {
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}

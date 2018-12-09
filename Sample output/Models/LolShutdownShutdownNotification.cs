using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolShutdownShutdownNotification
    {
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
        [JsonProperty("countdown")]
        public float Countdown { get; set; }
        [JsonProperty("reason")]
        public LolShutdownShutdownReason Reason { get; set; }
    }
}

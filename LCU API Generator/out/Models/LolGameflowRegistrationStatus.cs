using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolGameflowRegistrationStatus
    {
        [JsonProperty("complete")]
        public bool Complete { get; set; }
        [JsonProperty("errorCodes")]
        public string[] ErrorCodes { get; set; }
    }
}

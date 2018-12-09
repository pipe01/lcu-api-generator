using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyRegistrationStatus
    {
        [JsonProperty("complete")]
        public bool Complete { get; set; }
        [JsonProperty("errorCodes")]
        public string[] ErrorCodes { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolKickoutKickoutMessage
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

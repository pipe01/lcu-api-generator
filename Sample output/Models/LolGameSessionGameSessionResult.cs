using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolGameSessionGameSessionResult
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

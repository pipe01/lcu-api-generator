using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class BasePlayerDTO
    {
        [JsonProperty("code")]
        public int Code { get; set; }
        [JsonProperty("data")]
        public MatchedPlayerDTO Data { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
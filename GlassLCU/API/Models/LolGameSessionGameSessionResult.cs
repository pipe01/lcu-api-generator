using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGameSessionGameSessionResult
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

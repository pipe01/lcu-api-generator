using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolKickoutKickoutMessage
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

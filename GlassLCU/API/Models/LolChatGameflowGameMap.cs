using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChatGameflowGameMap
    {
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}

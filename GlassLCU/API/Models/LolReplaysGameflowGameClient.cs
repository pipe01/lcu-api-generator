using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolReplaysGameflowGameClient
    {
        [JsonProperty("running")]
        public bool Running { get; set; }
    }
}

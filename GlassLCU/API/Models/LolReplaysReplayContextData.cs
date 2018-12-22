using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolReplaysReplayContextData
    {
        [JsonProperty("componentType")]
        public string ComponentType { get; set; }
    }
}

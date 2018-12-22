using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampSelectLegacyGameflowGameClient
    {
        [JsonProperty("running")]
        public bool Running { get; set; }
        [JsonProperty("visible")]
        public bool Visible { get; set; }
    }
}

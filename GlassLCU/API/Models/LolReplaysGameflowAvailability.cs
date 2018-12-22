using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolReplaysGameflowAvailability
    {
        [JsonProperty("state")]
        public string State { get; set; }
    }
}

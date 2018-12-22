using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEndOfGameGameflowAvailability
    {
        [JsonProperty("state")]
        public string State { get; set; }
    }
}

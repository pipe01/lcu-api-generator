using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashRMSMessage
    {
        [JsonProperty("payload")]
        public string Payload { get; set; }
    }
}

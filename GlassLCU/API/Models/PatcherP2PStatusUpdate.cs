using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PatcherP2PStatusUpdate
    {
        [JsonProperty("isAllowedByUser")]
        public bool IsAllowedByUser { get; set; }
    }
}

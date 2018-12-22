using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPerksServiceSettings
    {
        [JsonProperty("serverSideStorageAvailable")]
        public bool ServerSideStorageAvailable { get; set; }
    }
}

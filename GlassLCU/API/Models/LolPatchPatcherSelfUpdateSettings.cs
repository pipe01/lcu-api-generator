using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPatchPatcherSelfUpdateSettings
    {
        [JsonProperty("restart_delay")]
        public int Restart_delay { get; set; }
    }
}

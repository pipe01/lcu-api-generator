using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMissionsGameflowSession
    {
        [JsonProperty("phase")]
        public LolMissionsGameflowPhase Phase { get; set; }
    }
}

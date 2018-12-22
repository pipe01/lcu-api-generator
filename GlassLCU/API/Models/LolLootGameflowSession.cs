using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootGameflowSession
    {
        [JsonProperty("phase")]
        public LolLootGameflowPhase Phase { get; set; }
    }
}

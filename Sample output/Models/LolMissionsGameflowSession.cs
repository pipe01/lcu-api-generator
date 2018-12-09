using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMissionsGameflowSession
    {
        [JsonProperty("phase")]
        public LolMissionsGameflowPhase Phase { get; set; }
    }
}

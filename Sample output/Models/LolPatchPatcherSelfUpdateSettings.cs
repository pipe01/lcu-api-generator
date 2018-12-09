using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPatchPatcherSelfUpdateSettings
    {
        [JsonProperty("restart_delay")]
        public int Restart_delay { get; set; }
    }
}

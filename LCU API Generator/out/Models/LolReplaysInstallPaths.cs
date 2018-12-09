using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolReplaysInstallPaths
    {
        [JsonProperty("gameExecutablePath")]
        public string GameExecutablePath { get; set; }
        [JsonProperty("gameInstallRoot")]
        public string GameInstallRoot { get; set; }
    }
}

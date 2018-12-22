using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

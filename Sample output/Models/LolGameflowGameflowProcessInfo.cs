//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGameflowGameflowProcessInfo
    {
        [JsonProperty("pid")]
        public int Pid { get; set; }
        [JsonProperty("rawArgs")]
        public string[] RawArgs { get; set; }
    }
}

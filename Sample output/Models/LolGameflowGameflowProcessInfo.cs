using Newtonsoft.Json;

namespace LCU_API_Generator
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

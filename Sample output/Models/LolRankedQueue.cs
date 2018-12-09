using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRankedQueue
    {
        [JsonProperty("type")]
        public object Type { get; set; }
    }
}

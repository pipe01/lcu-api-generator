using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashProfileInfo
    {
        [JsonProperty("honorLevel")]
        public int HonorLevel { get; set; }
    }
}

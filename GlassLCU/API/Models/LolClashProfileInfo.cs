using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashProfileInfo
    {
        [JsonProperty("honorLevel")]
        public int HonorLevel { get; set; }
    }
}

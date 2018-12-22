using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolAcsAcsEndPoint
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

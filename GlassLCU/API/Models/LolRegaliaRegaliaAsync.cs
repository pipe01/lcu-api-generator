using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRegaliaRegaliaAsync
    {
        [JsonProperty("md5")]
        public string Md5 { get; set; }
    }
}

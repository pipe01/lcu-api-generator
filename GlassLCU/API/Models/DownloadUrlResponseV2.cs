using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class DownloadUrlResponseV2
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

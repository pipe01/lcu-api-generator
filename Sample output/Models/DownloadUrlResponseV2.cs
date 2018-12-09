using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class DownloadUrlResponseV2
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class DownloadUrlRequestV2
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
    }
}

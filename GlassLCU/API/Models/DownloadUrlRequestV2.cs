using Newtonsoft.Json;

namespace GlassLCU.API.Models
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

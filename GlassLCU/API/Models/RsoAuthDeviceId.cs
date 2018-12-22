using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RsoAuthDeviceId
    {
        [JsonProperty("collectorServerName")]
        public string CollectorServerName { get; set; }
        [JsonProperty("frameUrl")]
        public string FrameUrl { get; set; }
        [JsonProperty("installId")]
        public string InstallId { get; set; }
        [JsonProperty("merchantId")]
        public string MerchantId { get; set; }
        [JsonProperty("sessionId")]
        public string SessionId { get; set; }
    }
}

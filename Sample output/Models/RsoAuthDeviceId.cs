using Newtonsoft.Json;

namespace LCU_API_Generator
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

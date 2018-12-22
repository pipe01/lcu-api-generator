using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class VoiceChatCodecSettingsResource
    {
        [JsonProperty("codecBandwidth")]
        public int CodecBandwidth { get; set; }
        [JsonProperty("codecBitrate")]
        public int CodecBitrate { get; set; }
        [JsonProperty("codecComplexity")]
        public int CodecComplexity { get; set; }
        [JsonProperty("codecVbrMode")]
        public int CodecVbrMode { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class VoiceChatUpdateCodecSettingsResource
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

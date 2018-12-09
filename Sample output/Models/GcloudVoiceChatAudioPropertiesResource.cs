using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class GcloudVoiceChatAudioPropertiesResource
    {
        [JsonProperty("fastEnergyMeter")]
        public float FastEnergyMeter { get; set; }
        [JsonProperty("isLoopbackEnabled")]
        public bool IsLoopbackEnabled { get; set; }
        [JsonProperty("isMicActive")]
        public bool IsMicActive { get; set; }
        [JsonProperty("isSpeakerActive")]
        public bool IsSpeakerActive { get; set; }
        [JsonProperty("micEnergy")]
        public int MicEnergy { get; set; }
        [JsonProperty("micVolume")]
        public int MicVolume { get; set; }
        [JsonProperty("noiseFloorMeter")]
        public float NoiseFloorMeter { get; set; }
        [JsonProperty("speakerEnergy")]
        public int SpeakerEnergy { get; set; }
        [JsonProperty("speakerVolume")]
        public int SpeakerVolume { get; set; }
        [JsonProperty("speechThresholdMeter")]
        public float SpeechThresholdMeter { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPremadeVoiceVoiceAvailability
    {
        [JsonProperty("connectedToVoiceServer")]
        public bool ConnectedToVoiceServer { get; set; }
        [JsonProperty("disabledAfterLogin")]
        public bool DisabledAfterLogin { get; set; }
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("showDisconnectedState")]
        public bool ShowDisconnectedState { get; set; }
        [JsonProperty("showUI")]
        public bool ShowUI { get; set; }
        [JsonProperty("voiceChannelAvailable")]
        public bool VoiceChannelAvailable { get; set; }
    }
}

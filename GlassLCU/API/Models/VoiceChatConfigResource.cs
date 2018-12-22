using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class VoiceChatConfigResource
    {
        [JsonProperty("accessTokenUri")]
        public string AccessTokenUri { get; set; }
        [JsonProperty("authTokenUri")]
        public string AuthTokenUri { get; set; }
        [JsonProperty("jwt2gvtUrl")]
        public string Jwt2gvtUrl { get; set; }
        [JsonProperty("logLevel")]
        public int LogLevel { get; set; }
        [JsonProperty("logLevelName")]
        public string LogLevelName { get; set; }
        [JsonProperty("logsPath")]
        public string LogsPath { get; set; }
        [JsonProperty("provider")]
        public string Provider { get; set; }
        [JsonProperty("useExternalAuth")]
        public bool UseExternalAuth { get; set; }
        [JsonProperty("voiceDomain")]
        public string VoiceDomain { get; set; }
        [JsonProperty("voiceServerUri")]
        public string VoiceServerUri { get; set; }
    }
}

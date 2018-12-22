using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPftPFTMetadata
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("appName")]
        public string AppName { get; set; }
        [JsonProperty("appVersion")]
        public string AppVersion { get; set; }
        [JsonProperty("env")]
        public string Env { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("stats")]
        public LolPftPFTEndOfGameStats Stats { get; set; }
        [JsonProperty("systemOs")]
        public string SystemOs { get; set; }
        [JsonProperty("webRegion")]
        public string WebRegion { get; set; }
    }
}
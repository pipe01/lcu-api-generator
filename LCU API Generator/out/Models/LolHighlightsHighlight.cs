using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolHighlightsHighlight
    {
        [JsonProperty("fileSizeBytes")]
        public long FileSizeBytes { get; set; }
        [JsonProperty("filepath")]
        public string Filepath { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("mtimeIso8601")]
        public string MtimeIso8601 { get; set; }
        [JsonProperty("mtimeMsUtc")]
        public long MtimeMsUtc { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

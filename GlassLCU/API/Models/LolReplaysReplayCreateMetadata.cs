using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolReplaysReplayCreateMetadata
    {
        [JsonProperty("gameEnd")]
        public long GameEnd { get; set; }
        [JsonProperty("gameType")]
        public string GameType { get; set; }
        [JsonProperty("gameVersion")]
        public string GameVersion { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
    }
}

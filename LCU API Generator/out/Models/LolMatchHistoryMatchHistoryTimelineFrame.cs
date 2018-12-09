using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMatchHistoryMatchHistoryTimelineFrame
    {
        [JsonProperty("events")]
        public LolMatchHistoryMatchHistoryEvent[] Events { get; set; }
        [JsonProperty("participantFrames")]
        public object ParticipantFrames { get; set; }
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}

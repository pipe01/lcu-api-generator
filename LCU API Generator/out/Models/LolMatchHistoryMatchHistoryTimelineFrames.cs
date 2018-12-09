using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMatchHistoryMatchHistoryTimelineFrames
    {
        [JsonProperty("frames")]
        public LolMatchHistoryMatchHistoryTimelineFrame[] Frames { get; set; }
    }
}

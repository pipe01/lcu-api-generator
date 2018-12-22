using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMatchHistoryMatchHistoryTimelineFrames
    {
        [JsonProperty("frames")]
        public LolMatchHistoryMatchHistoryTimelineFrame[] Frames { get; set; }
    }
}

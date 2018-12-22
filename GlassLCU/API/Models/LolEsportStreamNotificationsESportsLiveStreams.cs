using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEsportStreamNotificationsESportsLiveStreams
    {
        [JsonProperty("liveStreams")]
        public LolEsportStreamNotificationsESportsStreams[] LiveStreams { get; set; }
    }
}

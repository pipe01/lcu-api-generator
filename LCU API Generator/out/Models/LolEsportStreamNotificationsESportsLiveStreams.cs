using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolEsportStreamNotificationsESportsLiveStreams
    {
        [JsonProperty("liveStreams")]
        public LolEsportStreamNotificationsESportsStreams[] LiveStreams { get; set; }
    }
}

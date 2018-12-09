using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolEsportStreamNotificationsESportsAPI_streamgroups
    {
        [JsonProperty("content")]
        public string Content { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("live")]
        public bool Live { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}

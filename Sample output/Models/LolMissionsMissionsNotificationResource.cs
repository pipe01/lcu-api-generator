using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMissionsMissionsNotificationResource
    {
        [JsonProperty("backgroundUrl")]
        public string BackgroundUrl { get; set; }
        [JsonProperty("created")]
        public string Created { get; set; }
        [JsonProperty("critical")]
        public bool Critical { get; set; }
        [JsonProperty("data")]
        public object Data { get; set; }
        [JsonProperty("detailKey")]
        public string DetailKey { get; set; }
        [JsonProperty("expires")]
        public string Expires { get; set; }
        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("titleKey")]
        public string TitleKey { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolEsportStreamNotificationsESportStreamNotificationsConfig
    {
        [JsonProperty("beappFailureLongPollMinutes")]
        public long BeappFailureLongPollMinutes { get; set; }
        [JsonProperty("notificationsAssetMagickURL")]
        public string NotificationsAssetMagickURL { get; set; }
        [JsonProperty("notificationsEnabled")]
        public bool NotificationsEnabled { get; set; }
        [JsonProperty("notificationsLongPollMinutes")]
        public long NotificationsLongPollMinutes { get; set; }
        [JsonProperty("notificationsServiceEndpoint")]
        public string NotificationsServiceEndpoint { get; set; }
        [JsonProperty("notificationsServiceEndpointV2")]
        public string NotificationsServiceEndpointV2 { get; set; }
        [JsonProperty("notificationsShortPollMinutes")]
        public long NotificationsShortPollMinutes { get; set; }
        [JsonProperty("notificationsStreamGroupSlug")]
        public string NotificationsStreamGroupSlug { get; set; }
        [JsonProperty("notificationsStreamURL")]
        public string NotificationsStreamURL { get; set; }
        [JsonProperty("useServiceEndpointV2")]
        public bool UseServiceEndpointV2 { get; set; }
    }
}
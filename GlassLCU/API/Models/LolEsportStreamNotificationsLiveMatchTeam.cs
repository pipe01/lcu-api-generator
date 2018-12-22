using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEsportStreamNotificationsLiveMatchTeam
    {
        [JsonProperty("acronym")]
        public string Acronym { get; set; }
        [JsonProperty("guid")]
        public string Guid { get; set; }
        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

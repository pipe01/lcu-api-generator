using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolEsportStreamNotificationsEsportsAPI_teams
    {
        [JsonProperty("acronym")]
        public string Acronym { get; set; }
        [JsonProperty("guid")]
        public string Guid { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
    }
}
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolServiceStatusTickerMessage
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
        [JsonProperty("heading")]
        public string Heading { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("severity")]
        public LolServiceStatusServiceStatusIncident_Severity Severity { get; set; }
        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }
}

using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClubsClubMOTD
    {
        [JsonProperty("motd")]
        public string Motd { get; set; }
    }
}

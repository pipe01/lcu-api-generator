using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsClubMOTD
    {
        [JsonProperty("motd")]
        public string Motd { get; set; }
    }
}

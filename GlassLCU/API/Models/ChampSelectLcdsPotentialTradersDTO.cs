using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class ChampSelectLcdsPotentialTradersDTO
    {
        [JsonProperty("potentialTraders")]
        public string[] PotentialTraders { get; set; }
    }
}

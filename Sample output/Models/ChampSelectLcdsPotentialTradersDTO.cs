using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class ChampSelectLcdsPotentialTradersDTO
    {
        [JsonProperty("potentialTraders")]
        public string[] PotentialTraders { get; set; }
    }
}

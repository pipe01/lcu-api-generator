using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class EndOfGameLcdsTeamId
    {
        [JsonProperty("fullId")]
        public string FullId { get; set; }
    }
}

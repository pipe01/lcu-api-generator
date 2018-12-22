using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PlayerParticipant
    {
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
